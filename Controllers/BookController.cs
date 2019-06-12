using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementApp.Data.Interfaces;
using LibraryManagementApp.Data.Model;
using LibraryManagementApp.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementApp.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;

        public BookController(IBookRepository bookRepository,IAuthorRepository authorRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
        }
        [Route("Book")]
        public IActionResult List(int? authorId, int? borrowerId)
        {
            if (authorId == null && borrowerId == null)
            {
                var books = _bookRepository.GetAllWithAuthor();
                return CheckBooks(books);
            }
            else if (authorId == null)
            {
                var author = _authorRepository.GetWithBooks((int)authorId);
                if (author.Books.Count() == 0)
                {
                    return View("AuthorEmpty", author);
                }
                else
                {
                    return View(author.Books);
                }
            }
            else if (borrowerId == null)
            {
                var books = _bookRepository.FindWithAuthorAndBorrower(book => book.BorrowerId == borrowerId);
                return CheckBooks(books);
            }
            else
            {
                throw new ArgumentException();
            }
                       
        }

        public IActionResult CheckBooks(IEnumerable<Book> books)
        {
            if (books.Count() == 0)
            {
                return View("Empty");
            }
            else
            {
                return View(books);
            }
        }

        public IActionResult Create()
        {
            var bookVM = new BookViewModel()
            {
                Authors = _authorRepository.GetAll()
            };
            return View(bookVM);
        }
        [HttpPost]
        public IActionResult Create(BookViewModel bookViewModel)
        {
            if (!ModelState.IsValid)
            {
                bookViewModel.Authors = _authorRepository.GetAll();
                return View(bookViewModel);
            }
            //bookViewModel.Book.BorrowerId = 4;
            _bookRepository.Create(bookViewModel.Book);
            return RedirectToAction("List");
        }

        public IActionResult Update()
        {
            var bookVM = new BookViewModel()
            {
                Authors = _authorRepository.GetAll()
            };
            return View(bookVM);
        }
        [HttpPost]
        public IActionResult Update(BookViewModel bookViewModel)
        {
            if (!ModelState.IsValid)
            {
                bookViewModel.Authors = _authorRepository.GetAll();
                return View(bookViewModel);
            }
            _bookRepository.Create(bookViewModel.Book);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id) {
            var book = _bookRepository.GetById(id);
            _bookRepository.Delete(book);
            return RedirectToAction("List");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}