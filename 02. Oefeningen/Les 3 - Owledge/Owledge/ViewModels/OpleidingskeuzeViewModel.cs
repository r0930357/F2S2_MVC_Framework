using System.ComponentModel.DataAnnotations;

namespace Owledge.ViewModels
{
    public class OpleidingskeuzeViewModel
    {
        [Required]
        public string Opleiding { get; set; } = default!;
        public bool InleidingInBedrijfskunde { get; set; }
        public bool ScrumVoorBeginners { get; set; }
    }
}
