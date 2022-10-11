namespace CashRegister.Models
{
    public class Produkt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Preis { get; set; }
        public bool Preisart { get; set; }
        public List<EinkaufsPosition> EinkaufsPositionen { get; set; }
        public int KategorieId { get; set; }
        public Kategorie Kategorie { get; set; }

    }
}
