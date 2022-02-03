using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBooksMarquetIntroduction.Models.Entities;

namespace WebBooksMarquetIntroduction.Models.DTOs
{
    public class BookDTO : EntityBase
    {
        public String Name { get; set; }
        public String Author { get; set; }
        public String Publisher { get; set; }

        public BookDTO()
        {

        }

        public BookDTO(string id, string name, string author, string publisher) : this(name, author, publisher)
        {
            Id = id;
        }

        public BookDTO(string name, string author, string publisher)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
        }

    }
}
