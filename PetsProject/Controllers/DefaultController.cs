using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PetsProject.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IPetPostService _petPostService;
        public DefaultController(IPetPostService petPostService)
        {
            _petPostService = petPostService;
        }

        public IActionResult Index()
        {
            var values = _petPostService.GetListActivePost(true);
            return View(values);
        }
        [HttpGet]
        public IActionResult GetListByCategory(int id)
        {
            var values = _petPostService.GetListCategory(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult GetListByType(int id)
        {
            var values = _petPostService.GetListType(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult GetListByAge(int id)
        {
            var values = _petPostService.GetListAge(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult GetListByBreed(int id)
        {
            var values = _petPostService.GetListBreed(id);         
            return View(values);
        }


     
      

    }
}
