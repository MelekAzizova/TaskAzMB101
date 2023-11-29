using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using System.Diagnostics;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var dt = await SqlHelpers.GetDatas("SELECT*FROM Employee");
            return View(dt);
        }
        public IActionResult Tables()
        {
            return View();
        }
    }
}