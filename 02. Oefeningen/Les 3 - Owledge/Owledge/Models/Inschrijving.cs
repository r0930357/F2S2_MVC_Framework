using System.ComponentModel.DataAnnotations;

namespace Owledge.Models
{
    public class Inschrijving
    {
        [Required (ErrorMessage = "Vul een voornaam in aub")]
        public string Voornaam { get; set; } = default!;
        [Required(ErrorMessage = "Vul een familienaam in aub")]
        public string Familienaam { get; set;} = default!;
        public string Roepnaam { get; set; } = default!;
        [Required(ErrorMessage = "Vul een geboortedatum in aub")]
        [DataType(DataType.Date)]
        public DateTime Geboortedatum { get; set; }
        [Required(ErrorMessage = "Vul een telefoonnummer in aub")]
        public string Telefoonnummer { get; set; } = default!;
        public string Opleiding {  get; set; } = default!;
        public List<string> KeuzeVakken {  get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Straat { get; set; } = default!;
        public string Huisnummer { get; set; } = default!;
        public int Postcode { get; set; }
        public string Gemeente { get; set; } = default!;
    }
}
