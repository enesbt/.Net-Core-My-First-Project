using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PetsProject.ViewComponents.DefaultDetails
{
	public class DefaultDetailsPetTypes:ViewComponent
	{
		private readonly IPetTypeService _petTypeService;

		public DefaultDetailsPetTypes(IPetTypeService petTypeService)
		{
			_petTypeService = petTypeService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _petTypeService.GetList();
			return View(values);
		}
	}
}
