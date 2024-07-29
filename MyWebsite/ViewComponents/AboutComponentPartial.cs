using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.ViewComponents
{
    public class AboutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}
