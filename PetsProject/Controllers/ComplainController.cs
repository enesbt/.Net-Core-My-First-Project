using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PetsProject.Controllers
{
	public class ComplainController : Controller
	{
        private readonly IComplainService _complainService;

        public ComplainController(IComplainService complainService)
        {
            _complainService = complainService;
        }

        public IActionResult Index()
		{
			return View();
		}
        [HttpGet]
        public IActionResult Complain(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public IActionResult Complain(Complain p)
        {
            _complainService.TAdd(p);
            return RedirectToAction("Index", "Default");
        }
    }
}
