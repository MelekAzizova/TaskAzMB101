using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Contexts;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        
        public async Task<IActionResult> Index()
        {
            using (PustokDbContex context = new())
            {
              var sliders = await context.Sliders.ToListAsync();

            return View(sliders);
            }
           

          



            
            
        }

        
    }
}