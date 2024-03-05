using _4Tune.Models;
using _4Tune.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _4Tune.Controllers
{
    public class AutoController : Controller
    {
        public List<Auto> Autos = new List<Auto>()
        {
            new Auto() { Id = 1, Merk = "Audi", Model = "A1 Sportback", Bouwjaar = 2023, Brandstofefficientie = 5.5, Prijs = 17855, Afbeelding = "audi-a1-sportback.jpg" },
            new Auto() { Id = 2, Merk = "Audi", Model = "A3 Sportback", Bouwjaar = 2022, Brandstofefficientie = 6.7, Prijs = 21675, Afbeelding = "audi-a3-sportback.jpg" },
            new Auto() { Id = 3, Merk = "Renault", Model = "Kangoo", Bouwjaar = 2020, Brandstofefficientie = 5.9, Prijs = 16500, Afbeelding = "renault-kangoo.jpg" },
            new Auto() { Id = 4, Merk = "Renault", Model = "Twingo", Bouwjaar = 2017, Brandstofefficientie = 4.7, Prijs = 5500, Afbeelding = "renault-twigo.jpg" },
            new Auto() { Id = 5, Merk = "Renault", Model = "Clio", Bouwjaar = 2014, Brandstofefficientie = 4.1, Prijs = 6999, Afbeelding = "renault-clio.jpg" },
            new Auto() { Id = 6, Merk = "Opel", Model = "Mokka", Bouwjaar = 2020, Brandstofefficientie = 7.9, Prijs = 22499, Afbeelding = "opel-mokka.jpg" },
            new Auto() { Id = 7, Merk = "Opel", Model = "Astra", Bouwjaar = 2017, Brandstofefficientie = 5.9, Prijs = 14599, Afbeelding = "opel-astra.jpg" },
            new Auto() { Id = 8, Merk = "Opel", Model = "Corsa", Bouwjaar = 2009, Brandstofefficientie = 3.6, Prijs = 5750, Afbeelding = "opel-corsa.jpg" },
        };

        public IActionResult Index()
        {
            List<Auto> gesorteerdeAutos = Autos.OrderBy(auto => auto.Merk).ToList();

            OverzichtAutosViewModel vm = new OverzichtAutosViewModel();
            vm.Autos = gesorteerdeAutos;
            return View(vm);
        }

        public IActionResult Detail(int id)
        {
            AutoDetailsViewModel vm = new AutoDetailsViewModel();

            foreach (var auto in Autos)
            {
                if (auto.Id == id)
                {
                    vm.Auto = auto;
                }
            }

            return View(vm);
        }
    }
}
