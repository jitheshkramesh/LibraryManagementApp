using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementApp.Data.Interfaces;
using LibraryManagementApp.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementApp.Controllers
{
    [Authorize]
    public class LendController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICustomerRepository _customerRepository;

        public LendController(IBookRepository bookRepository,ICustomerRepository customerRepository)
        {
            _bookRepository = bookRepository;
            _customerRepository = customerRepository;

        }

        [Route("Lend")]
        public IActionResult List()
        {
            int cnt = _bookRepository.GetAll().Count();
            var availableBooks = _bookRepository.FindWithAuthor(x =>(int) x.BorrowerId == 0);
            if (availableBooks.Count() == 0)
            {
                return View("Empty");               
            }
            else
            {
                return View(availableBooks);
            }
        }

        public IActionResult LendBook(int bookId)
        {
            var lendVM = new LendViewModel()
            {
                Book = _bookRepository.GetById(bookId),
                Customers = _customerRepository.GetAll()
            };
            return View(lendVM);
        }

        [HttpPost]
        public IActionResult LendBook(LendViewModel lendViewModel)
        {
            var book = _bookRepository.GetById(lendViewModel.Book.BookId);
            var customer = _customerRepository.GetById(lendViewModel.Book.BorrowerId);
            book.Borrower = customer;
            _bookRepository.Update(book);
            return RedirectToAction("List");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}