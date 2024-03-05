using DemoMVC.Models;
using DemoMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class MVC2Controller : Controller
    {

        public List<Product> producten = new List<Product>()
        {
            new Product() { ProductID = 1, Naam = "Heren T-shirt printed by TOM TAYLOR", Prijs = 8.39m },
            new Product() { ProductID = 2, Naam = "Heren broek Navy by LUIS CHINO", Prijs = 27.99m },
            new Product() { ProductID = 3, Naam = "Heren T-shirt met dessin by TOM TAYLOR", Prijs = 10.00m },
            new Product() { ProductID = 4, Naam = "Heren broek Army by LUIS CHINO", Prijs = 24.62m },
            new Product() { ProductID = 5, Naam = "Heren T-shirt met print by WE Fashion", Prijs = 9.00m }
        };

        public List<Klant> klanten = new()
        {
            new Klant() { KlantID = 1, Voornaam = "Anneleen", Familienaam = "De Neve", AangemaaktDatum = new DateTime(2019, 1, 20) },
            new Klant() { KlantID = 2, Voornaam = "Nele", Familienaam = "Bruynseels", AangemaaktDatum = new DateTime(2020, 2, 4) },
            new Klant() { KlantID = 3, Voornaam = "Joris", Familienaam = "Naert", AangemaaktDatum = new DateTime(2020, 1, 5) },
            new Klant() { KlantID = 4, Voornaam = "Jan", Familienaam = "Vermeire", AangemaaktDatum = new DateTime(2021, 7, 13) },
            new Klant() { KlantID = 5, Voornaam = "Sasha", Familienaam = "Van Gompel", AangemaaktDatum = new DateTime(2022, 9, 25) }
        };

        public IActionResult Index()
        {
            return View(klanten);
        }

        public IActionResult VolledigOverzicht()
        {
            
            VolledigOverzichtViewModel vm = new VolledigOverzichtViewModel();

            vm.Naam = "Nancy";
            vm.Producten = producten;

            return View(vm);
        }
    }
}
