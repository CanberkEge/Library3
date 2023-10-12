using AutoMapper;
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
    public class CategoryController : Controller
    {
        private readonly SqlDbContext dbContext;
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly IMapper mapper;

        public CategoryController(SqlDbContext dbContext, IWebHostEnvironment hostEnvironment, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.hostEnvironment = hostEnvironment;
            this.mapper = mapper;
        }

        // GET:Category

        public async Task<IActionResult> Index()
        {
            if(dbContext.Categories != null)
            {
                return View(await dbContext.Categories.ToListAsync());
            }
            else
            {
                return Problem("Entity set 'SqlDbContext.Categories' is null.");

            }
        }

        //GET: Category/Details/5

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || dbContext.Categories == null) 
            { 
                return NotFound();
            }
            var category = await dbContext.Categories.FirstOrDefaultAsync(p=> p.Id == id);
            if (category== null)
            {
                return NotFound();
            }
            return View(category);
        }

        //GET: Category/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //POST: Category/Create
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(CategoryCreateDTO createDTO)
        {
            if (ModelState.IsValid)
            {
                var path = Path.Combine(hostEnvironment.WebRootPath, "images_category");
                if (Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);

                }

                var filename = Path.Combine(path, createDTO.CategoryPhoto.FileName);
                using (var filetrans = new FileStream(filename, FileMode.Create))
                {
                    await createDTO.CategoryPhoto.CopyToAsync(filetrans);
                }

                createDTO.CategoryPhotoName = createDTO.CategoryPhoto.FileName;

                var result = mapper.Map<Category>(createDTO);
                dbContext.Add(result);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(createDTO); ;
        }

        //GET: CategoryController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || dbContext.Categories == null)
            {
                return NotFound();
            }

            var category = await dbContext.Categories.FirstOrDefaultAsync(p => p.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: CategoryController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (dbContext.Categories == null)
            {
                return Problem("Entity set 'SqlDbContext.Categories' is null.");
            }

            var category = await dbContext.Categories.FindAsync(id);

            if (category != null)
            {
                dbContext.Categories.Remove(category);
            }

            await dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Category/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || dbContext.Categories == null)
            {
                return NotFound();
            }

            var category = await dbContext.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    dbContext.Update(category);
                    await dbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        private bool CategoryExists(int id)
        {
            return (dbContext.Categories?.Any(p => p.Id == id)).GetValueOrDefault();
        }

    }
}
