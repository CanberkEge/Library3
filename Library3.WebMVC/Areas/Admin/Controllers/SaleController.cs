using AutoMapper;
using Library3.Business.Abstract;
using Library3.DAL.Context;
using Library3.Entity.Concrete;
using Library3.WebMVC.Areas.Admin.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Library3.WebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class SaleController : Controller
    {


        private readonly ISaleManager saleManager;
        private readonly IMapper mapper;
        private readonly SqlDbContext dbContext;
        private readonly IBookManager bookManager;

        public SaleController(ISaleManager saleManager, IMapper mapper, SqlDbContext dbContext, IBookManager bookManager)
        {
            this.saleManager = saleManager;
            this.mapper = mapper;
            this.dbContext = dbContext;
            this.bookManager = bookManager;
        }

        public async Task<IActionResult> SaleIndex()
        {
            var sales = await saleManager.GetAllInclude(null, p => p.Book);
            return View(sales);
        }
        public async Task<IActionResult> Index()
        {
            var book = await bookManager.GetAllAsync();
            var sales = await saleManager.GetAllInclude(null, p => p.Book);

            var booksMapped = mapper.Map<List<Book>>(book);
            var salesMapped = mapper.Map<List<Sale>>(sales);

            var viewModel = new BookSaleViewDTO
            {
                Books = booksMapped,
                Sales = salesMapped
            };

            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Created(List<int> selectedBooks, BookSaleViewDTO model)
        {
            if (selectedBooks != null && selectedBooks.Any())
            {
                foreach (var bookId in selectedBooks)
                {
                    var saleBook = new Sale()
                    {
                        BookId = bookId,
                        StartDate = DateTime.Now,
                        DiscountRate = model.DiscountRate,
                        EndDate = model.EndDate,
                    };

                    dbContext.Sales.Add(saleBook);
                }

                await dbContext.SaveChangesAsync();

                return RedirectToAction(nameof(SaleIndex));
            }
            return View(nameof(Index));
        }
        public async Task<ActionResult> Delete(int id)
        {
            var sale = await dbContext.Sales
                .Include(s => s.Book)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (sale == null)
            {
                return NotFound();
            }

            ViewData["BookName"] = sale.Book.BookName;
            ViewData["BookAuthor"] = sale.Book.Author;
            ViewData["BookEdition"] = sale.Book.Edition;

            return View(sale);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var sale = await saleManager.GetByIdAsync(id);
            if (sale != null)
            {
                await saleManager.DeleteAsync(sale);
            }
            return RedirectToAction(nameof(SaleIndex));
        }












    }
}
