using System.ComponentModel.DataAnnotations;

namespace Owledge.ViewModels
{
    public class ContactgegevensViewModel
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = default!;
        public string Straat { get; set; } = default!;
        public string Huisnummer { get; set; } = default!;
        public int Postcode { get; set; }
        public string Gemeente { get; set; } = default!;
    }
}
