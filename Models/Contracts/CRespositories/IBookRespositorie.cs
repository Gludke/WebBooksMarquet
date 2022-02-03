using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBooksMarquetIntroduction.Models.DTOs;

namespace WebBooksMarquetIntroduction.Models.Contracts.CRepositories
{
    public interface IBookRespositorie
    {
        public List<BookDTO> ListBooks();
        public void Register(BookDTO book);
        BookDTO SearchBookWithId(string idBook);
        void UpdateBook(BookDTO book);
    }
}
