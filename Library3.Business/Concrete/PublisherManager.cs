using Library3.Business.Abstract;
using Library3.DAL.Abstract;
using Library3.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3.Business.Concrete
{
    public class PublisherManager : BaseManager<Publisher>, IPublisherManager
    {
        public PublisherManager(IPublisherRepository repository) : base(repository)  
        {
            
        }
    }
}
