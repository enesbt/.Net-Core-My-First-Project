using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetsProject.Models;

namespace PetsProject.Controllers
{
    public class LoginController : Controller
    {
        readonly SignInManager<AppUser> _signInManager;
        readonly UserManager<AppUser> _userManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(SignInViewModel signInViewModel)
        {
            if (ModelState.IsValid)
            {
                var result =await _signInManager.PasswordSignInAsync(signInViewModel.UserName, signInViewModel.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "MemberHome", new {area="Member"});
                }
                else
                {
                    return View();
                }
               
            }
            return View();
        }
        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
