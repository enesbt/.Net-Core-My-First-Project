using Microsoft.AspNetCore.Mvc;

namespace PetsProject.Controllers
{
    public class ErrorPageController : Controller
    {

        public IActionResult Index404()
        {
            return View();
        }
    }
}
