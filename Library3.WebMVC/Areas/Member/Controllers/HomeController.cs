using Library3.Business.Abstract;
using Library3.Entity.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Library3.WebMVC.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles ="Member")]
    public class HomeController : Controller
    {

        private readonly ISaleManager saleManager;
        private readonly UserManager<AppUser> userManager;

        public HomeController(ISaleManager saleManager, UserManager<AppUser> userManager)
        {
            this.saleManager = saleManager;
            this.userManager = userManager;
        }
public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await userManager.FindByNameAsync(User.Identity.Name);
                ViewData["user"] = "Welcome " + user.UserName;
            }

            var sale = await saleManager.GetAllInclude(null, p => p.Book);
            return View(sale);
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
