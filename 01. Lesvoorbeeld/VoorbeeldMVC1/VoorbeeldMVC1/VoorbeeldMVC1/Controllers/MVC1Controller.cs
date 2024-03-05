using Microsoft.AspNetCore.Mvc;

namespace VoorbeeldMVC1.Controllers
{
    public class MVC1Controller : Controller
    {
        public string Index()
        {
            return "Dit is de 'Index' pagina!";
        }

        public string Welkom()
        {
            return "Dit is de 'Welkom' pagina!";
        }

        public string Bestelling(int id)
        {
            return $"Dit zijn de details van bestelling met id {id}";
        }

        public string Boodschap(string voornaam, string boodschap)
        {
            return $"Boodschap van {voornaam}: {boodschap}";
        }

        public IActionResult HelloView()
        {
            return View();
        }

        public IActionResult HelloRazor()
        {
            ViewData["Title"] = "HelloRazor";
            return View();
        }


    }
}
