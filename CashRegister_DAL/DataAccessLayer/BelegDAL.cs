using CashRegister.DAL;
using CashRegister.Models;

namespace CashRegister_DAL.DataAccessLayer
{
    public class BelegDAL
    {
        CashRegisterContextDB context;
        public BelegDAL(CashRegisterContextDB context)
        {
            this.context = context;
        }


        //Gibt den Gesamtpreis zurück (Alle zwischen ergebnisse zusammengerechnet)
        public double GetGesamtPreis(List<EinkaufsPosition> einkaufsPosition)
        {
            double gesamtPreis = 0;
            foreach (EinkaufsPosition einkaufsPositionsProdukt in einkaufsPosition)
            {
                gesamtPreis = gesamtPreis + (einkaufsPositionsProdukt.Anzahl * einkaufsPositionsProdukt.Produkt.Preis);
            }
            return gesamtPreis;
        }

        //Beleg wird erstellt
        public void Create(List<EinkaufsPosition> einkaufsposition)
        {
            Beleg beleg = new Beleg
            {
                Kaufdatum = DateTime.Now,
                Gesamtpreis = GetGesamtPreis(einkaufsposition),
            };
            beleg.EinkaufsPosition.AddRange(einkaufsposition);
            context.Add(beleg);
        }
    }
}
