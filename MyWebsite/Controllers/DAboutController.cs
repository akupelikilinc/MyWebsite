using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebsite.DAL.Context;
using MyWebsite.DAL.Entities;

namespace MyWebsite.Controllers
{
    public class DaboutController : Controller
    {
        MyWebsiteContext context = new MyWebsiteContext();
       
            public IActionResult About()
        {
            // About nesnelerinin listesi
            //List<About> aboutList = context.Abouts.ToList();
            //return View(aboutList);
        
          
            // About nesnelerinin listesi
            List<About> aboutList = context.Abouts.ToList();
                return View(aboutList);
            


        }



    }
}