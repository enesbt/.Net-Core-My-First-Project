using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace PetsProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AgeController : Controller
    {
        private readonly IPetAgeService _petAgeService;

        public AgeController(IPetAgeService petAgeService)
        {
            _petAgeService = petAgeService;
        }

        public IActionResult Index()
        {
            var values = _petAgeService.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAge()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAge(PetAge p)
        {
            p.Status = true;
            _petAgeService.TAdd(p);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult EditAge(int id)
        {
            var age = _petAgeService.GetById(id);
            return View(age);
        }
        [HttpPost]
        public IActionResult EditAge(PetAge p)
        {
            p.Status = true;
            _petAgeService.TUpdate(p);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult ActiveAge(int id)
        {
            var age = _petAgeService.GetById(id);
            age.Status = true;
            _petAgeService.TUpdate(age);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult PassiveAge(int id)
        {
            var age = _petAgeService.GetById(id);
            age.Status = false;
            _petAgeService.TUpdate(age);
            return RedirectToAction("Index", "Home");
        }

    }
}
