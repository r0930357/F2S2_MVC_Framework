namespace VoorbeeldFormulieren.Models
{
    public class Gebruiker
    {
        public int GebruikerId { get; set; }

        [Required (ErrorMessage = "Vul een voornaam in aub")]
        public string Voornaam { get; set; }

        [Required (ErrorMessage = "Vul een familienaam in aub")]
        public string Familienaam { get; set; }

        [Required (ErrorMessage = "Vul een geboortedatum in aub")]
        [DataType(DataType.Date)]
        public DateTime Geboortedatum { get; set; }

        public string Geslacht { get; set; }

        public string? Afbeelding { get; set; }
    }
}
