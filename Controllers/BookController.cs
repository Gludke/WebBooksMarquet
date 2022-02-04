using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBooksMarquetIntroduction.Models.Contracts.CServices;
using WebBooksMarquetIntroduction.Models.DTOs;

namespace WebBooksMarquetIntroduction.Controllers
{
    public class BookController : Controller
    {
        public IBookService _bookService { get; }

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            try 
            {
                var books = _bookService.ListBooks();
                return View(books);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Leva para a view de criação
        public IActionResult Create()
        {
            return View();
        }

        //Cria o novo livro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookDTO book)
        {
            try
            {
                _bookService.Register(book);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Leva para a view de edição
        public IActionResult Edit(string idBook)
        {
            if (String.IsNullOrEmpty(idBook))
                return NotFound();

            try
            {
                var book = _bookService.SearchBookWithId(idBook);
                if (book == null)
                    return NotFound();

                return View(book);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Edita os dados do livro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BookDTO book)
        {
            if (String.IsNullOrEmpty(book.Id))
                return NotFound();

            try
            {
                _bookService.UpdateBook(book);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public IActionResult Details(string idBook)
        {
            if (String.IsNullOrEmpty(idBook))
                return NotFound();

            try
            {
                var book = _bookService.SearchBookWithId(idBook);
                if (book == null)
                    return NotFound();

                return View(book);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Remove(string idBook)
        {
            if (String.IsNullOrEmpty(idBook))
                return NotFound();

            try
            {
                _bookService.Remove(idBook);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
