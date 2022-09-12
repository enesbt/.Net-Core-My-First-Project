using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PetsProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class CityController : Controller
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        public IActionResult Index()
        {
            var values = _cityService.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCity()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult AddCity(City p)
        {
            _cityService.TAdd(p);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult EditCity(int id)
        {
            var city = _cityService.GetById(id);
            ViewBag.city = id;
            return View(city);
        }
        [HttpPost]
        public IActionResult EditCity(City p)
        {
            _cityService.TUpdate(p);
            return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public IActionResult DeleteCity(int id)
        {
            var city = _cityService.GetById(id);
            _cityService.TRemove(city);
            return RedirectToAction("Index", "Home");
        }
    }
}
