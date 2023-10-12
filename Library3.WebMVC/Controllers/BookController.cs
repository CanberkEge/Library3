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
        public async Task <IActionResult> Index()
        {

            var books = await bookManager.GetAllAsync();

            return View(books);

        }
    }
}
