using Library3.Business.Abstract;
using Library3.Business.Concrete;
using Library3.DAL.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Library3.WebMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly SqlDbContext dbContext;
        

        public CategoryController(SqlDbContext dbContext)
        {
            this.dbContext = dbContext;
            
        }

        public async Task<IActionResult> Index()
        {
            if (dbContext.Categories !=null)
            {
                return View(await dbContext.Categories.ToListAsync());
            }
            else
            {
                return Problem("Entity set 'SqlDbContext.Categories' is null.");
            }
        }

        public async Task<IActionResult> Details(int? id) 
        {
            if (id == null || dbContext.Categories == null)
            {
                return NotFound();
            }
            
            var category = await dbContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
            
        }

        public async Task<IActionResult> BookInCategory(int categoryId) 
        {
            BookManager bookManager = new BookManager();
            var booksInCategory = await bookManager.GetAllInclude(null, c => c.Category);
            var filteredBooks = booksInCategory.Where(c => c.Category!= null && c.Category.Id == categoryId).ToList();

            var categoryName = dbContext.Categories.FirstOrDefault(p => p.Id == categoryId);
            if (categoryName != null)
            {
                ViewData["CategoryName"] = categoryName.CategoryName;
            }

            return View(filteredBooks);
        }
        
            
        
    }
}
