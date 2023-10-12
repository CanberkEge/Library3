using AutoMapper;
using Library3.Business.Abstract;
using Library3.DAL.Context;
using Library3.Entity.Concrete;
using Library3.WebMVC.Areas.Admin.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Library3.WebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BookController : Controller
    {
        private readonly SqlDbContext dbContext;
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly IBookManager bookManager;
        private readonly IMapper mapper;
        ICategoryManager categoryManager;

        //private readonly IMapper mapper;


        public BookController(SqlDbContext dbContext, IWebHostEnvironment hostEnvironment, ICategoryManager categoryManager, IMapper mapper) 

        {
            this.dbContext = dbContext;
            this.hostEnvironment = hostEnvironment;
            this.bookManager = bookManager;
            this.categoryManager = categoryManager;
            this.mapper = mapper;

            //this.mapper=mapper;
        }

        public async Task<ActionResult> Index()
        {
            var books = await bookManager.GetAllInclude(null, p => p.Category);
            return View(books);
        }
        public ActionResult Details(int id)
        {
            return View();
        }


        //GET: BookController/Create    
        [HttpGet]
        
        public async Task<ActionResult> Create()
        {
            BookCreateDTO createDTO = new();
            var categories = categoryManager.GetAllAsync().Result.Select(p=> new SelectListItem {  Text = p.CategoryName, Value = p.Id.ToString() });

            ViewBag.Categories = categories;
            return View(createDTO);
        }

        // POST: ProductController/Create
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]

        public async Task <ActionResult> Create(BookCreateDTO createDTO)
        {
            if (ModelState.IsValid)
            {
                var path = Path.Combine(hostEnvironment.WebRootPath, "images_books");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                var filename = Path.Combine(path, createDTO.BookPhoto.FileName);
                using (var filetrans = new FileStream(filename, FileMode.Create))
                {
                    await createDTO.BookPhoto.CopyToAsync(filetrans);
                }
                createDTO.BookPhotoName = createDTO.BookPhoto.FileName;

                var result = mapper.Map<Book>(createDTO);
                dbContext.Add(result);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(createDTO);
        }
            
        //GET: BookController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var book = await bookManager.GetByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        //POST: Book/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var book = await bookManager.GetByIdAsync(id);
            if (book != null)
            {
                await bookManager.DeleteAsync(book);    

            }
            return RedirectToAction(nameof(Index));
        }

        //GET: BookController/Edit/5

        public async Task<ActionResult> Edit(int id)
        {
            var book = await bookManager.GetByIdAsync(id);
            var categories = categoryManager.GetAllAsync().Result.Select(p=> new SelectListItem { Text = p.CategoryName, Value = p.Id.ToString() });

            ViewBag.Categories = categories;
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        //POST: BookController/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Edit(int id, Book book)
        {
            if (id != book.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    await bookManager.UpdateAsync(book);
                }
                catch (Exception ex)
                {
                    if (await bookManager.GetByIdAsync(id)==null)
                    {
                        return NotFound();

                    }
                    else
                    {
                        ModelState.AddModelError("", ex.Message);

                    }
                }
                return RedirectToAction(nameof(Index));

            }
            return View(book);
        }

        
    }
}
