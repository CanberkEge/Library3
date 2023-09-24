using Library3.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3.Entity.Concrete
{
    public class Staff : BaseEntity
    {
        public string StaffFirstName { get; set; }
        public string StaffLastName { get; set; }
        public ICollection<Book>? Books { get; set; }
        public ICollection<Reader> Readers { get; set; }

    }
}
