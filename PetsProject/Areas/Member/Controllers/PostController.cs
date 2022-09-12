using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace PetsProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    public class PostController : Controller
    {
        private readonly IPetPostService _petPostService;
        private readonly ICategoryService _categoryService;
        private readonly IPetTypeService _petTypeService;
        private readonly IPetBreedService _petBreedService;
        private readonly ICityService _cityService;
        private readonly IPetAgeService _ageService;

        public PostController(IPetPostService petPostService, ICategoryService categoryService, IPetTypeService petTypeService, IPetBreedService petBreedService, ICityService cityService, IPetAgeService ageService)
        {
            _petPostService = petPostService;
            _categoryService = categoryService;
            _petTypeService = petTypeService;
            _petBreedService = petBreedService;
            _cityService = cityService;
            _ageService = ageService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddPost()
        {
            List<SelectListItem> category = (from item in _categoryService.GetActiveCategory(true)
                                             select new SelectListItem
                                             {
                                                 Text = item.CategoryName,
                                                 Value = item.CategoryId.ToString()
                                             }).ToList();
            List<SelectListItem> type = (from item in _petTypeService.GetActiveType(true)
                                             select new SelectListItem
                                             {
                                                 Text = item.PetTypeName,
                                                 Value = item.PetTypeId.ToString()
                                             }).ToList();
            List<SelectListItem> breed = (from item in _petBreedService.GetActiveBreed(true)
                                             select new SelectListItem
                                             {
                                                 Text = item.PetBreedName,
                                                 Value = item.PetBreedId.ToString()
                                             }).ToList();
            List<SelectListItem> city = (from item in _cityService.GetList()
                                             select new SelectListItem
                                             {
                                                 Text = item.CityName,
                                                 Value = item.CityId.ToString()
                                             }).ToList();
            List<SelectListItem> age = (from item in _ageService.GetActiveAge(true)
                                         select new SelectListItem
                                         {
                                             Text = item.Age,
                                             Value = item.PetAgeId.ToString()
                                         }).ToList();
            ViewBag.category = category;
            ViewBag.type = type;
            ViewBag.city = city;
            ViewBag.breed = breed;
            ViewBag.age = age;
            ViewBag.name = User.Identity.Name;
            return View();
        }
        [HttpPost]
        public IActionResult AddPost(PetPost p)
        {
            p.Status = true;
            p.PostTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            _petPostService.TAdd(p);
            return RedirectToAction("Index", "MemberHome");
        }

        public IActionResult MyPosts()
        {
            var post = _petPostService.GetListMebmerPost(User.Identity.Name);          
            return View(post);
        }
        [HttpGet]
        public IActionResult EditPost(int id)
        {
            List<SelectListItem> category = (from item in _categoryService.GetActiveCategory(true)
                                             select new SelectListItem
                                             {
                                                 Text = item.CategoryName,
                                                 Value = item.CategoryId.ToString()
                                             }).ToList();
            List<SelectListItem> type = (from item in _petTypeService.GetActiveType(true)
                                         select new SelectListItem
                                         {
                                             Text = item.PetTypeName,
                                             Value = item.PetTypeId.ToString()
                                         }).ToList();
            List<SelectListItem> breed = (from item in _petBreedService.GetActiveBreed(true)
                                          select new SelectListItem
                                          {
                                              Text = item.PetBreedName,
                                              Value = item.PetBreedId.ToString()
                                          }).ToList();
            List<SelectListItem> city = (from item in _cityService.GetList()
                                         select new SelectListItem
                                         {
                                             Text = item.CityName,
                                             Value = item.CityId.ToString()
                                         }).ToList();
            List<SelectListItem> age = (from item in _ageService.GetActiveAge(true)
                                        select new SelectListItem
                                        {
                                            Text = item.Age,
                                            Value = item.PetAgeId.ToString()
                                        }).ToList();
            ViewBag.category = category;
            ViewBag.type = type;
            ViewBag.city = city;
            ViewBag.breed = breed;
            ViewBag.age = age;
            ViewBag.name = User.Identity.Name;
            var value = _petPostService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditPost(PetPost p)
        {
            p.Status = true;
            p.PostTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            _petPostService.TUpdate(p);
            return RedirectToAction("Index", "MemberHome");
        }
        [HttpGet]
        public IActionResult DetailsPost(int id)
        {
            var post = _petPostService.GetPostValues(id);
            return View(post);
        }
        [HttpGet]
        public IActionResult ActivePost(int id)
        {
            var post = _petPostService.GetById(id);
            post.Status = true;
            _petPostService.TUpdate(post);
            return RedirectToAction("Index", "MemberHome");
        }
        [HttpGet]
        public IActionResult PassivePost(int id)
        {
            var post = _petPostService.GetById(id);
            post.Status = false;
            _petPostService.TUpdate(post);
            return RedirectToAction("Index", "MemberHome");
        }

    }
}
