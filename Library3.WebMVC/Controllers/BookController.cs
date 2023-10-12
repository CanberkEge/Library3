using Library3.Business.Abstract;
using Library3.Business.Concrete;
using Library3.DAL.Context;
using Library3.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Diagnostics;

namespace Library3.WebMVC.Controllers
{
    public class BookController : Controller
    {
        private readonly SqlDbContext dbContext;
        private readonly IBookManager bookManager;

        public BookController(SqlDbContext dbContext, IBookManager bookManager)
        {
            this.dbContext = dbContext;
            this.bookManager = bookManager;
        }
        public async Task<IActionResult> Index()
        {
            if (dbContext.Books != null)
            {
                return View(await dbContext.Books.ToListAsync());
            }
            else
            {
                return Problem("Entity set 'SqlDbContext.Books' is null");
            }
        }

            //var books = await bookManager.GetAllAsync();

            //return View(books);

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
