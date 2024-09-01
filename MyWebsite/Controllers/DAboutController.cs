using Microsoft.AspNetCore.Mvc;
using MyWebsite.DAL.Context;

namespace MyWebsite.Controllers
{
    public class DAboutController:Controller
    {
        MyWebsiteContext context = new MyWebsiteContext();
        public IActionResult DAbout()

        {
            var values = context.Abouts.ToList().FirstOrDefault();
            return View(values); 
        }
    }
}
