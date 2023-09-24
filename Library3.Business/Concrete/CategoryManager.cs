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
    public class CategoryManager : BaseManager<Category>, ICategoryManager
    {
        public CategoryManager(ICategoryRepository repository) : base(repository)  
        {
            
        }
    }
}
