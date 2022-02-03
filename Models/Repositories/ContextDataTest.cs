using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBooksMarquetIntroduction.Models.DTOs;

namespace WebBooksMarquetIntroduction.Models.Repositories
{
    public static class ContextDataTest
    {
        public static List<BookDTO> listaLivros;

        static ContextDataTest()
        {
            InitializeData();
        }

        private static void InitializeData()
        {
            listaLivros = new List<BookDTO>
                {
                new BookDTO("Nome1", "Autor1", "Editora1"),
                new BookDTO("Nome2", "Autor2", "Editora2"),
                new BookDTO("Nome3", "Autor3", "Editora3"),
                new BookDTO("Nome4", "Autor4", "Editora4"),
                new BookDTO("Nome5", "Autor5", "Editora5"),
                new BookDTO("Nome6", "Autor6", "Editora6"),
                };
        }
    }
}
