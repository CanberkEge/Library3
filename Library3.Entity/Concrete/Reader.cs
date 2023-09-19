using Library3.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3.Entity.Concrete
{
    public class Reader : BaseEntity
    {
        public string ReaderFirsName { get; set; }
        public string ReaderLastName { get; set; }
        public string Adress {  get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
