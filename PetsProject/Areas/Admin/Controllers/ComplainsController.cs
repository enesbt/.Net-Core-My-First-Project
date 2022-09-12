using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PetsProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class ComplainsController : Controller
    {
        private readonly IComplainService _complainService;
        private readonly IPetPostService _petPostService;

        public ComplainsController(IComplainService complainService, IPetPostService petPostService)
        {
            _complainService = complainService;
            _petPostService = petPostService;
        }

        public IActionResult Index()
        {
            var values = _complainService.GetList();
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
        [HttpGet]
        public IActionResult ActiveComplain(int id)
        {
            var complain = _complainService.GetById(id);
            complain.Status = true;
            _complainService.TUpdate(complain);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult PassiveComplain(int id)
        {
            var complain = _complainService.GetById(id);
            complain.Status = false;
            _complainService.TUpdate(complain);
            return RedirectToAction("Index", "Home");
        }

    }
}
