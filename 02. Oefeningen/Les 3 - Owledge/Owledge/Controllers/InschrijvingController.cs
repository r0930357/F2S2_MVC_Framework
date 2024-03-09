using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Owledge.Models;
using Owledge.ViewModels;
using System.Runtime.CompilerServices;

namespace Owledge.Controllers
{
    public class InschrijvingController : Controller
    {

        private static Inschrijving inschrijving = default!;
     
        public IActionResult Index()
        {
            return RedirectToAction(nameof(Opleidingskeuze));
        }

        public IActionResult Opleidingskeuze()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Opleidingskeuze(OpleidingskeuzeViewModel vm)
        {
            inschrijving = new Inschrijving();
            inschrijving.Opleiding = vm.Opleiding;
            inschrijving.KeuzeVakken = new List<string>();
            if (vm.InleidingInBedrijfskunde)
            {
                inschrijving.KeuzeVakken.Add("Inleiding tot bedrijfskunde");
            }
            if (vm.ScrumVoorBeginners)
            {
                inschrijving.KeuzeVakken.Add("Scrum voor beginners");
            }

            return RedirectToAction(nameof(Persoonsgegevens));
        }

        public IActionResult Persoonsgegevens()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Persoonsgegevens(PersoonsgegevensViewModel vm)
        {
            inschrijving.Voornaam = vm.Voornaam;
            inschrijving.Familienaam = vm.Familienaam;
            inschrijving.Roepnaam = vm.Roepnaam;
            inschrijving.Geboortedatum = vm.Geboortedatum;
            inschrijving.Telefoonnummer = vm.Telefoonnummer;

            return RedirectToAction(nameof(Contactgegevens));
        }
        
        public IActionResult Contactgegevens()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contactgegevens(ContactgegevensViewModel vm)
        {
            inschrijving.Email = vm.Email;
            inschrijving.Straat = vm.Straat;
            inschrijving.Huisnummer = vm.Huisnummer;
            inschrijving.Postcode = vm.Postcode;
            inschrijving.Gemeente = vm.Gemeente;

            return RedirectToAction(nameof(Bevestiging));
        }

        public IActionResult Bevestiging()
        {
            BevestigingViewModel vm = new BevestigingViewModel();
            vm.Inschrijving = inschrijving;
            return View();
        }
    }
}
