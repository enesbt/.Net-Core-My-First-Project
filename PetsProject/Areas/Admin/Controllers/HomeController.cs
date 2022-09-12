using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetsProject.Areas.Admin.Models;

namespace PetsProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    [Authorize(Roles ="Admin")]
    public class HomeController : Controller
    {
        readonly UserManager<AppUser> _userManager;

        public HomeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values =await _userManager.FindByNameAsync(User.Identity.Name);
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> AdminEdit()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            AdminEditViewModel model = new AdminEditViewModel();
            model.UserName = values.UserName;
            model.Name = values.Name;
            model.Email = values.Email;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AdminEdit(AdminEditViewModel adminEditViewModel)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.UserName = adminEditViewModel.UserName;
            values.Email = adminEditViewModel.Email;
            values.Name = adminEditViewModel.Name;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, adminEditViewModel.Password);
            var result = await _userManager.UpdateAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}
