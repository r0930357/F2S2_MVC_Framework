using Microsoft.AspNetCore.Mvc;
using Rekenhulpje.Models;
using System.Diagnostics;

namespace Rekenhulpje.Controllers
{
    public class MachtstafelsController : Controller
    {
        public IActionResult Index(int aantal)
        {
            ViewData["Aantal"] = aantal;
            return View();
        }

        public IActionResult Details(int tafel)
        {
            ViewData["Tafel"] = tafel;
            return View();
        }
    }
}