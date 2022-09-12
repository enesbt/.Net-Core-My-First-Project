using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PetsProject.ViewComponents.Default
{
	public class DefaultFilterType: ViewComponent
    {
        private readonly IPetTypeService _petTypeService;

        public DefaultFilterType(IPetTypeService petTypeService)
        {
            _petTypeService = petTypeService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _petTypeService.GetActiveType(true);
            return View(values);
        }
    }
}
