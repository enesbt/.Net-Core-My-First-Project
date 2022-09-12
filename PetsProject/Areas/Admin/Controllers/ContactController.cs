using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PetsProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class ContactController : Controller
    {
        readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.GetList();
            return View(values);  
        }
        [HttpGet]
        public IActionResult ActiveContact(int id)
        {
            var contact = _contactService.GetById(id);
            contact.Status = true;
            _contactService.TUpdate(contact);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult PassiveContact(int id)
        {
            var contact = _contactService.GetById(id);
            contact.Status = false;
            _contactService.TUpdate(contact);
            return RedirectToAction("Index", "Home");
        }
    }
}
