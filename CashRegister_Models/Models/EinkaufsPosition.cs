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


        public decimal CalcGesamtPreis(List<EinkaufsPosition> einkaufsPositionList)
        {

            decimal gesamtPreis = 0;
            foreach (EinkaufsPosition einkaufsPositionsProdukt in einkaufsPositionList)
            {
                gesamtPreis = gesamtPreis + (einkaufsPositionsProdukt.Anzahl * einkaufsPositionsProdukt.Produkt.Preis);
            }
            return gesamtPreis;
        }



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
