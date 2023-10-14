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
        public DateTime? ReserveDate {get; set;}
        public DateTime? DueDate {  get; set; }
        public DateTime? ReturnDate { get; set; }

        public Category? Category { get; set; }
        public Reader? Reader { get; set; }
        public Publisher? Publisher { get; set; }
        public Staff? Staff { get; set; }

        public int? CategoryId { get; set; }

        public string? BookPhotoName { get; set; }

        public ICollection<Sale>? Sales { get; set; }
        public ICollection<Cart>? Carts { get; set; }



    }
}
