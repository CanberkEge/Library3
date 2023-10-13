using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library3.WebMVC.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles ="Member")]
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
