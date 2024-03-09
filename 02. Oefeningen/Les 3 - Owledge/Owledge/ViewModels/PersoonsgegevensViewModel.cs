using System.ComponentModel.DataAnnotations;

namespace Owledge.ViewModels
{
    public class PersoonsgegevensViewModel
    {
        public string Voornaam { get; set; } = default!;
        public string Familienaam { get; set; } = default!;
        public string Roepnaam { get; set; } = default!;

        [DataType(DataType.Date)]
        public DateTime Geboortedatum { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Telefoonnummer { get; set; } = default!;
    }
}
