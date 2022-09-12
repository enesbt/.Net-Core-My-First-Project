using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PetsProject.ViewComponents.Default
{
	public class DefaultSliderComponent:ViewComponent
	{
		private readonly IPetPostService _petPostService;

		public DefaultSliderComponent(IPetPostService petPostService)
		{
			_petPostService = petPostService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _petPostService.GetListSlider();
			return View(values);
		}
	}
}
