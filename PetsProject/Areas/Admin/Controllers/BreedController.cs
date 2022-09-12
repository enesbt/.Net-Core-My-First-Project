using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace PetsProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BreedController : Controller
    {
        private readonly IPetBreedService _petBreedService;
        private readonly IPetTypeService _petTypeService;

        public BreedController(IPetBreedService petBreedService, IPetTypeService petTypeService)
        {
            _petBreedService = petBreedService;
            _petTypeService = petTypeService;
        }

        public IActionResult Index()
        {
            var values = _petBreedService.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddBreed()
        {
            List<SelectListItem> type = (from item in _petTypeService.GetActiveType(true)
                                             select new SelectListItem
                                             {
                                                 Text = item.PetTypeName,
                                                 Value = item.PetTypeId.ToString()
                                             }).ToList();
            ViewBag.type = type;
            return View();
        }
        [HttpPost]
        public IActionResult AddBreed(PetBreed p)
        {
            p.Status = true;
            _petBreedService.TAdd(p);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult EditBreed(int id)
        {
            var breed = _petBreedService.GetById(id);
            List<SelectListItem> type = (from item in _petTypeService.GetActiveType(true)
                                         select new SelectListItem
                                         {
                                             Text = item.PetTypeName,
                                             Value = item.PetTypeId.ToString()
                                         }).ToList();
            ViewBag.type = type;
            return View(breed);
        }
        [HttpPost]
        public IActionResult EditBreed(PetBreed p)
        {
            p.Status = true;
            _petBreedService.TUpdate(p);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult ActiveType(int id)
        {
            var breed = _petBreedService.GetById(id);
            breed.Status = true;
            _petBreedService.TUpdate(breed);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult PassiveType(int id)
        {
            var breed = _petBreedService.GetById(id);
            breed.Status = false;
            _petBreedService.TUpdate(breed);
            return RedirectToAction("Index", "Home");
        }
    }
}
