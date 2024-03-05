using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Klant
    {
        public int KlantID { get; set; }

        public string Voornaam { get; set; } = default!;

        public string Familienaam { get; set; } = default!;

        [DataType(DataType.Date)]
        public DateTime AangemaaktDatum { get; set; }
    }

}
