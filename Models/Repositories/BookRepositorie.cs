using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBooksMarquetIntroduction.Models.Contracts.CRepositories;
using WebBooksMarquetIntroduction.Models.DTOs;

namespace WebBooksMarquetIntroduction.Models.Repositories
{
    public class BookRepositorie : IBookRespositorie
    {
        public List<BookDTO> ListBooks()
        {
            var listBooks = ContextDataTest.listaLivros;
            return listBooks
                .OrderBy(b => b.Name)
                .ToList();
        }

        public void Register(BookDTO book)
        {
            ContextDataTest.listaLivros.Add(book);
        }

        public void Remove(string idBook)
        {
            var bookToRemove = ContextDataTest.listaLivros
                .Where(b => b.Id == idBook)
                .FirstOrDefault();

            if (bookToRemove != null)
                ContextDataTest.listaLivros.Remove(bookToRemove);
        }

        public BookDTO SearchBookWithId(string idBook)
        {
            return ContextDataTest.listaLivros
                .Where(b => b.Id == idBook)
                .FirstOrDefault();
        }

        public void UpdateBook(BookDTO newBook)
        {
            var book = SearchBookWithId(newBook.Id);
            ContextDataTest.listaLivros.Remove(book);

            book.Name = newBook.Name;
            book.Author = newBook.Author;
            book.Publisher = newBook.Publisher;

            Register(book);
        }
    }
}
