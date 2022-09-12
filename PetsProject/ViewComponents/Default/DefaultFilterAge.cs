using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PetsProject.ViewComponents.Default
{
	public class DefaultFilterAge:ViewComponent
	{
		private readonly IPetAgeService _petAgeService;

		public DefaultFilterAge(IPetAgeService petAgeService)
		{
			_petAgeService = petAgeService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _petAgeService.GetActiveAge(true);
			return View(values);
		}
	}
}
