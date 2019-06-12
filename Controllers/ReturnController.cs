using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementApp.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementApp.Controllers
{
    [Authorize]
    public class ReturnController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICustomerRepository _customerRepository;

        public ReturnController(IBookRepository bookRepository,ICustomerRepository customerRepository)
        {
            _bookRepository = bookRepository;
            _customerRepository = customerRepository;
        }

        [Route("Return")]
        public IActionResult List() {
            var borrowedBooks = _bookRepository.FindWithAuthorAndBorrower(x => x.BorrowerId != 0);
            // Check the books collection
            if (borrowedBooks == null || borrowedBooks.ToList().Count() == 0)
            {
                return View("Empty");
            }
            return View(borrowedBooks);
        }

        public IActionResult ReturnABook(int bookId) {
            var book = _bookRepository.GetById(bookId);

            book.Borrower = null;

            book.BorrowerId = 0;

            _bookRepository.Update(book);

            return RedirectToAction("List");

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}