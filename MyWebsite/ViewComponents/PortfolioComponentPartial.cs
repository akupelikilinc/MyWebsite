using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.ViewComponents
{
	public class PortfolioComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
