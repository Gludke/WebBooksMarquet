using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBooksMarquetIntroduction.Models.DTOs;

namespace WebBooksMarquetIntroduction.Models.Contracts.CServices
{
    public interface IBookService
    {
        public List<BookDTO> ListBooks();
        public void Register(BookDTO book);
        BookDTO SearchBookWithId(string idBook);
        void UpdateBook(BookDTO book);
        void Remove(string idBook);
    }
}
