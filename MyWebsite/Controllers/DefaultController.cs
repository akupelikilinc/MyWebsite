using Microsoft.AspNetCore.Mvc;
using MyWebsite.DAL.Context;
using MyWebsite.DAL.Entities;

namespace MyWebsite.Controllers
{
    public class DefaultController:Controller
    {
        
        public IActionResult Index()
        {
            MyWebsiteContext context = new MyWebsiteContext();
            ViewBag.v  = context.Abouts.ToList().FirstOrDefault();
                       
            return View();
        }

    }
}
