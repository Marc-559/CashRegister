using System.ComponentModel.DataAnnotations;

namespace CashRegister.Models
{


    public class EinkaufsPosition
    {


        public int Id { get; set; }

        public int Anzahl { get; set; } = 0;

        [Required]
        public Beleg Beleg { get; set; }
        public Produkt Produkt { get; set; }

        public double CalcGesamtPreis(List<EinkaufsPosition> einkaufsPositionList)
        {
            double gesamtPreis = 0;
            foreach (EinkaufsPosition einkaufsPositionsProdukt in einkaufsPositionList)
            {
                gesamtPreis = gesamtPreis + (einkaufsPositionsProdukt.Anzahl * einkaufsPositionsProdukt.Produkt.Preis);
            }
            return Math.Round(gesamtPreis, 2);
        }

        
        public decimal ZwischenPreis

        {
            get { return (Anzahl * Produkt.Preis); }
        }

        public double ZwischenPreisRound
        {
            get { return Math.Round(ZwischenPreis, 2);  }
        }

        public string ProduktName
        {
            get { return Produkt.Name; }
        }
    }
}
