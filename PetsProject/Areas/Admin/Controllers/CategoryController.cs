using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace PetsProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _categoryService.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            p.Status = true;
            _categoryService.TAdd(p);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var category = _categoryService.GetById(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult EditCategory(Category p)
        {
            p.Status = true;
            _categoryService.TUpdate(p);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult ActiveCategory(int id)
        {
            var category = _categoryService.GetById(id);
            category.Status = true;
            _categoryService.TUpdate(category);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult PassiveCategory(int id)
        {
            var category = _categoryService.GetById(id);
            category.Status = false;
            _categoryService.TUpdate(category);
            return RedirectToAction("Index", "Home");
        }
       


    }
}
