using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetsProject.Areas.Member.Models;

namespace PetsProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[Controller]/[Action]")]
    [Authorize(Roles ="Member")]
    public class MemberHomeController : Controller
    {

        readonly UserManager<AppUser> _userManager;

        public MemberHomeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var name = User.Identity.Name;
            ViewBag.value = name;
            return View();
        }
        public async Task<IActionResult> Profile()
        {
            var values =await _userManager.FindByNameAsync(User.Identity.Name);
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> EditProfile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            EditProfileViewModel editProfileViewModel = new EditProfileViewModel();
            editProfileViewModel.Name = values.Name;
            editProfileViewModel.UserName = values.UserName;
            editProfileViewModel.Email = values.Email;
            return View(editProfileViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditProfile(EditProfileViewModel model)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.Name = model.Name;
            values.UserName = model.UserName;
            values.Email = model.Email;
            _userManager.PasswordHasher.HashPassword(values, model.Password);
            var result = await _userManager.UpdateAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Profile","MemberHome");
            }

            return View();
        }



    }
}
