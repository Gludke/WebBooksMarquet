using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBooksMarquetIntroduction.Models.Contracts.CRepositories;
using WebBooksMarquetIntroduction.Models.Contracts.CServices;
using WebBooksMarquetIntroduction.Models.DTOs;

namespace WebBooksMarquetIntroduction.Models.Services
{
    public class BookService : IBookService
    {
        public readonly IBookRespositorie _bookRepositorie;

        public BookService(IBookRespositorie bookRepositorie)
        {
            _bookRepositorie = bookRepositorie;
        }

        public List<BookDTO> ListBooks()
        {
            try
            {
                return _bookRepositorie.ListBooks();
            } 
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Register(BookDTO book)
        {
            try
            {
                _bookRepositorie.Register(book);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(string idBook)
        {
            _bookRepositorie.Remove(idBook);
        }

        public BookDTO SearchBookWithId(string idBook)
        {
            try
            {
                return _bookRepositorie.SearchBookWithId(idBook);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateBook(BookDTO book)
        {
            try
            {
                _bookRepositorie.UpdateBook(book);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
