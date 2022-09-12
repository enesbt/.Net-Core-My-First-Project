using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PetsProject.Controllers
{
    public class ContactMeController : Controller
    {
        private readonly IContactMeService _contactMeService;

        public ContactMeController(IContactMeService contactMeService)
        {
            _contactMeService = contactMeService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ContactMe(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public IActionResult ContactMe(ContactMe p)
        {
            _contactMeService.TAdd(p);
            return RedirectToAction("Index", "Default");
        }

    }
}
