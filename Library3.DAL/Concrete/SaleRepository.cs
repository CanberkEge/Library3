using Library3.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library3.Entity.Concrete;


namespace Library3.DAL.Concrete
{
    public class SaleRepository : BaseRepository<Sale>, ISaleRepository
    {
    }
}
