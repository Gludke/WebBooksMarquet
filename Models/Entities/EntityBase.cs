using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBooksMarquetIntroduction.Models.Entities
{
    public abstract class EntityBase
    {
        public string Id { get; set; }

        protected EntityBase()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
