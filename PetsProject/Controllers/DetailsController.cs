using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PetsProject.Controllers
{
	public class DetailsController : Controller
	{
        private readonly IPetPostService _petPostService;


        public DetailsController(IPetPostService petPostService)
        {
            _petPostService = petPostService;
        }

        public IActionResult Index()
		{
			return View();
		}
        [HttpGet]
        public IActionResult Details(int id)
        { 
            var value = _petPostService.GetById(id);
            return View(value);
        }
      
     

    }
}
