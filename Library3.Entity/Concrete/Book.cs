using Library3.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3.Entity.Concrete
{
    public class Book : BaseEntity
    {
        public string BookName { get; set; }
        public int PageNumber { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Edition { get; set; }
        public double Price { get; set; }
    }
}
