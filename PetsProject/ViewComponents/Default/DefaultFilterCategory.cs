using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PetsProject.ViewComponents.Default
{
	public class DefaultFilterCategory:ViewComponent
	{
		private readonly ICategoryService _categoryService;

		public DefaultFilterCategory(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _categoryService.GetActiveCategory(true);
			return View(values);
		}
	}
}
