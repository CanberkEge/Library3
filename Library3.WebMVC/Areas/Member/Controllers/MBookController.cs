using Library3.DAL.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Library3.WebMVC.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles ="Member")]

    public class MBookController : Controller
    {
        private readonly SqlDbContext dbContext;
        public MBookController(SqlDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            if (dbContext.Books != null) 
            {
                return View(await dbContext.Books.ToListAsync());
            }
            else
            {
                return Problem("Entity set 'SqlDbContext.Product' is null.");
            }
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || dbContext.Books == null)  
            {
                return NotFound();
            }

            var book = await dbContext.Books.FirstOrDefaultAsync(p=> p.Id == id);
            if (book == null)
            {
                return NotFound();
            }
        
        
        
            return View(book);
        }
    }
}
