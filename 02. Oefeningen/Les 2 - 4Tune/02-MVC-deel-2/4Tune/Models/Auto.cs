namespace _4Tune.Models
{
    public class Auto
    {
        public int Id { get; set; }
        public string Merk { get; set; } = default!;
        public string Model { get; set; } = default!;
        public int Bouwjaar { get; set; }
        public double Brandstofefficientie { get; set; }
        public decimal Prijs { get; set; }
        public string Afbeelding { get; set; } = default!;
        public string MerkModel { get { return $"{Merk} {Model}"; }}
        public string PrijsString{ get { return $"Voor slechts £{Prijs}"; }}
    }
}
