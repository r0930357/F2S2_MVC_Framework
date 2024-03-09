namespace VoorbeeldFormulieren.Controllers
{
    public class FormulierController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        public List<Product> producten = new List<Product>()
        {
            new Product() { ProductID = 1, Naam = "Heren T-shirt printed by TOM TAYLOR", Prijs = 8.39m },
            new Product() { ProductID = 2, Naam = "Heren broek Navy by LUIS CHINO", Prijs = 27.99m },
            new Product() { ProductID = 3, Naam = "Heren T-shirt met dessin by TOM TAYLOR", Prijs = 10.00m },
            new Product() { ProductID = 4, Naam = "Heren broek Army by LUIS CHINO", Prijs = 24.62m },
            new Product() { ProductID = 5, Naam = "Heren T-shirt met print by WE Fashion", Prijs = 9.00m }
        };

        public FormulierController(IWebHostEnvironment environment) { 
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OverzichtProducten()
        {
            OverzichtProductenViewModel vm = new OverzichtProductenViewModel();
            vm.Producten = producten;

            return View(vm);
        }

        public IActionResult FilterProducten(OverzichtProductenViewModel vm)
        {
            vm.Producten = !string.IsNullOrEmpty(vm.Zoekterm) ? 
                producten.Where(b => b.Naam.Contains(vm.Zoekterm)).ToList() :
                producten;
            
            return View("OverzichtProducten", vm);
        }

        public IActionResult Registreren()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registreren(RegistrerenViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Gebruiker gebruiker = new Gebruiker();
                gebruiker.GebruikerId = 1;
                gebruiker.Voornaam = vm.Gebruiker.Voornaam;
                gebruiker.Familienaam = vm.Gebruiker.Familienaam;
                gebruiker.Geboortedatum = vm.Gebruiker.Geboortedatum;
                gebruiker.Geslacht = vm.Gebruiker.Geslacht;
                gebruiker.Afbeelding = Upload(vm.Bestand);

                GebruikerDetailsViewModel viewModel = new()
                {
                    gebruiker = gebruiker
                };

                return View("GebruikerDetails",viewModel);
            }
            return View(vm);
        }

        private string Upload(IFormFile bestand)
        {
            if (bestand.Length > 0)
            {
                string pad = Path.Combine(_environment.WebRootPath, "Images");
                if (!Directory.Exists(pad))
                {
                    Directory.CreateDirectory(pad);
                }
                string bestandsnaam = Path.GetFileName(bestand.FileName);
                using (FileStream stream = new FileStream(Path.Combine(pad, bestandsnaam), FileMode.Create))
                {
                    bestand.CopyTo(stream);
                    return bestandsnaam;
                }
            }

            return null;
        }

    }
}
