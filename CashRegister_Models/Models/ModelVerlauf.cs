namespace CashRegister_Models.Models
{
    public class ModelVerlauf
    {
        public string ProduktName { get; set; } // Produkt Name
        public int Anzahl { get; set; } // Anzahl der Produkte die insgesamt gekauft wurden
        public decimal Gesamtpreis { get; set; } // Alle EInkaufspositionen Preise zusammen
    }
}
