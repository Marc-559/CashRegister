using System.ComponentModel.DataAnnotations;

namespace CashRegister.Models
{


    public class EinkaufsPosition
    {


        public int Id { get; set; }
        public int Anzahl { get; set; }

        [Required]
        public Beleg Beleg { get; set; }
        public Produkt Produkt { get; set; }

        public decimal ZwischenPreis
        {
            get { return (Anzahl * Produkt.Preis); }
        }

        public string ProduktName
        {
            get { return Produkt.Name; }
        }
    }
}
