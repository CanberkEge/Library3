using Library3.Business.Concrete;
using Library3.DAL.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Data;
using Library3.Business.Abstract;
using System.Net;
using Library3.WebMVC.Areas.Admin.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Library3.Entity.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Library3.WebMVC.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles ="Member")]


    public class MCategoryController : Controller
    {
        private readonly SqlDbContext dbContext;

        public MCategoryController(SqlDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            if(dbContext.Categories != null)
            {
                return View(await dbContext.Categories.ToListAsync());
            }
            else
            {
                return Problem("Entity set 'SqlDbContext.Categories' is null");
            }
        }
        public async Task<IActionResult> Details(int? id)

        {
            if (id == null || dbContext.Categories == null)
            {
                return NotFound();
            }
            var category = await dbContext.Categories.FirstOrDefaultAsync(p=> p.Id == id);  
            if (category == null)
            {
                return NotFound();
                
            }
            return View(category);
        }

        public async Task<IActionResult> BookInCategory(int categoryId)
        {
            BookManager bookManager = new BookManager();
            var booksInCategory = await bookManager.GetAllInclude(null, p => p.Category);
            var filteredBooks = booksInCategory.Where(propa=> propa.Category != null && propa.Category.Id == categoryId).ToList();

            var categoryName = dbContext.Categories.FirstOrDefault(c => c.Id == categoryId);
            if (categoryName != null) 
            {
                ViewData["CategoryName"] = categoryName.CategoryName;
            }

            return View(filteredBooks);
        }



        
    }
}
