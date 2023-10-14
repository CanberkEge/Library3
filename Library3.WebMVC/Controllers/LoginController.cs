using AutoMapper;
using Library3.Entity.Authentication;
using Library3.WebMVC.Models.DTO_s;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Library3.WebMVC.Controllers
{
    public class LoginController : Controller
    {

        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppRole> roleManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IMapper mapper;

        public LoginController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.mapper = mapper;
        }

        [HttpGet]



        public IActionResult Index()
        {
            LoginDTO loginDTO = new LoginDTO();

            return View(loginDTO);
        }

        [HttpPost]

        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            if (ModelState.IsValid)
            {
                AppUser? user = await userManager.FindByEmailAsync(loginDTO.Email);

                var result = await signInManager.PasswordSignInAsync(user, loginDTO.Password, true, true);
                var role = userManager.GetRolesAsync(user).Result.FirstOrDefault();

                if (result.Succeeded)
                {
                    if (role == "Admin")
                    {
                        return RedirectToAction("Index", "Home", new { Area = "Admin" });
                    }
                    else if (role == "Member")
                    {
                        return RedirectToAction("Index", "Home", new { Area = "Member" });
                    }
                }

            }

            ModelState.AddModelError("", "Wrong Password or Email Adress");
            return View(loginDTO);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            RegisterDTO registerDTO = new RegisterDTO();
            return View(registerDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO registerDTO)
        {
            AppUser user = mapper.Map<AppUser>(registerDTO);
            user.UserName = registerDTO.Email;

            var result = await userManager.CreateAsync(user, registerDTO.Password);
            if (result.Succeeded)
            {
                var userRole = await roleManager.FindByNameAsync("Member");
                if (userRole == null)
                {
                    userRole = new AppRole();
                    userRole.Name = "Member";
                    await roleManager.CreateAsync(userRole);

                }
                await userManager.AddToRoleAsync(user, userRole.Name);


                return RedirectToAction("Index", "Login", new { Area = "Default" });

            }
            ModelState.AddModelError("", "Registration Failed");
            return View(registerDTO);
        }
    }
}
