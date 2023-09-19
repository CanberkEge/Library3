using Library3.DAL.Abstract;
using Library3.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3.DAL.Concrete
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {

    }
}
