using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister.Models
{
    

    public class EinkaufsPosition
    {
        

        public int Id { get; set; }
        public int Anzahl { get; set; }
        public Beleg Beleg { get; set; }
        public Produkt Produkt { get; set; }

        public double CalcGesamtPreis(List<EinkaufsPosition> einkaufsPositionList)
        {
            double gesamtPreis = 0;
            foreach (EinkaufsPosition einkaufsPositionsProdukt in einkaufsPositionList)
            {
                gesamtPreis = gesamtPreis + (einkaufsPositionsProdukt.Anzahl * einkaufsPositionsProdukt.Produkt.Preis);
            }
            return gesamtPreis;
        }

        

        public double ZwischenPreis
        {
            get { return (Anzahl * Produkt.Preis); }
        }

        public string ProduktName
        {
            get { return Produkt.Name; }
        }
    }
}
