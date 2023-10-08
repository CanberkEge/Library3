using Microsoft.AspNetCore.Mvc;

namespace Library3.WebMVC.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
