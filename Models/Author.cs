using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPISampleHandsOn.Models
{
    public class Author :BaseEntity
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public virtual ICollection<Book> Books  { get; set; }

    }

    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public DateTime Year { get; set; }
    }
}
