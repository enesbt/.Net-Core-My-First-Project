using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace PetsProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    public class ContactMeController : Controller
    {
        private readonly IContactMeService _contactMeService;

        public ContactMeController(IContactMeService contactMeService)
        {
            _contactMeService = contactMeService;
        }

        public IActionResult Index()
        {
            var name = User.Identity.Name;
            var values= _contactMeService.GetMessageMember(name);
            return View(values);
        }
    }
}
