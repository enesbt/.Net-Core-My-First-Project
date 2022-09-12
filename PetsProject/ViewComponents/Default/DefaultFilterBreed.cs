using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PetsProject.ViewComponents.Default
{
	public class DefaultFilterBreed:ViewComponent
	{
        private readonly IPetBreedService _petBreedService;

        public DefaultFilterBreed(IPetBreedService petBreedService)
        {
            _petBreedService = petBreedService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _petBreedService.GetActiveBreed(true);
            return View(values);
        }
    }
}
