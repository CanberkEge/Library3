using Library3.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3.Entity.Concrete
{
    public class Publisher : BaseEntity
    {
        public string PublisherName { get; set; }

        public DateTime PublishYear { get; set; }
        public ICollection<Book>? Books { get; set; }

    }
}
