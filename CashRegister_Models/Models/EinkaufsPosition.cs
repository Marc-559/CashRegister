using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashRegister.Models
{


    public class EinkaufsPosition
    {


        public int Id { get; set; }
        public int Anzahl { get; set; } = 0;
        [Required]
        public Beleg Beleg { get; set; }
        public Produkt Produkt { get; set; }

        [Column(TypeName = "decimal(6, 3)")]
        public decimal ZwischenPreis

        {
            get { return (Anzahl * Produkt.Preis); }
        }

        public decimal ZwischenPreisRound
        {
            get { return Math.Round(ZwischenPreis, 2);  }
        }

        public string ProduktName
        {
            get { return Produkt.Name; }
        }
    }
}
