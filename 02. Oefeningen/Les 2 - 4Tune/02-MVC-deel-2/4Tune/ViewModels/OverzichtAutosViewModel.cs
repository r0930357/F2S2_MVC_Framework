using _4Tune.Models;

namespace _4Tune.ViewModels
{
    public class OverzichtAutosViewModel
    {
        public string Merk { get; set; } = default!;
        public string Model { get; set; } = default!;
        public int Bouwjaar { get; set; }
        public double Brandstofefficientie { get; set; }
        public decimal Prijs { get; set; }
        public List<Auto> Autos { get; set; } = default!;
        public string MerkModel { get { return $"{Merk} {Model}"; }}
        public string PrijsString { get { return $"Voor slechts £{Prijs}"; }}
    }
}