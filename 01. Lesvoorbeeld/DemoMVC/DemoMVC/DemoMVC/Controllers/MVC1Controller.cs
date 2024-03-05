using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class MVC1Controller : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "MVC1";
            return View();
        }
    }
}
