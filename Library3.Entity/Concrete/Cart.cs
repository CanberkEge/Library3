using Library3.Entity.Abstract;
using Library3.Entity.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3.Entity.Concrete
{
    public class Cart : BaseEntity
    {
        public int? Quantity { get; set; }
        public decimal? TotalPrice { get; set; }
        public bool? IsPaid { get; set; }
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public AppUser? User { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
