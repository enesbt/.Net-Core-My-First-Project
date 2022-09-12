using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace PetsProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TypeController : Controller
    {
        private readonly IPetTypeService _petTypeService;

        public TypeController(IPetTypeService petTypeService)
        {
            _petTypeService = petTypeService;
        }

        public IActionResult Index()
        {
            var values = _petTypeService.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddType()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddType(PetType p)
        {
            p.Status = true;
            _petTypeService.TAdd(p);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult EditType(int id)
        {
            var type = _petTypeService.GetById(id);
            return View(type);
        }
        [HttpPost]
        public IActionResult EditType(PetType p)
        {
            p.Status = true;
            _petTypeService.TUpdate(p);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult ActiveType(int id)
        {
            var type = _petTypeService.GetById(id);
            type.Status = true;
            _petTypeService.TUpdate(type);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult PassiveType(int id)
        {
            var type = _petTypeService.GetById(id);
            type.Status = false;
            _petTypeService.TUpdate(type);
            return RedirectToAction("Index", "Home");
        }
    }
}
