using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace PetsProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PostController : Controller
    {
        readonly IPetPostService _petPostService;

        public PostController(IPetPostService petPostService)
        {
            _petPostService = petPostService;
        }

        public IActionResult Index()
        {
            var values = _petPostService.GetListByValues();
            return View(values);
        }
        public IActionResult PostDetails(int id)
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
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult PassivePost(int id)
        {
            var post = _petPostService.GetById(id);
            post.Status = false;
            _petPostService.TUpdate(post);
            return RedirectToAction("Index", "Home");
        }
    }
}
