using DemoMVC.Models;

namespace DemoMVC.ViewModels
{
    public class VolledigOverzichtViewModel
    {
        public string Naam { get; set; } = default!;

        public List<Product> Producten { get; set; } = default!;
    }
}
