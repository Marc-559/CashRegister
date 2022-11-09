using CashRegister.DAL;
using CashRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_DAL.DataAccessLayer
{
    public class BelegDAL
    {
        CashRegisterContextDB context;
        public BelegDAL(CashRegisterContextDB context)
        {
            this.context = context;
        }

        //Holt alle Belege aus der Dtaenbank und gibt sie zurück
        public List<Beleg> GetBelege()
        {
            return context.Beleg.ToList();
        }

        double GetGesamtPreis(List<EinkaufsPosition> einkaufsPosition)
        {
            double gesamtPreis = 0;
            foreach (EinkaufsPosition einkaufsPositionsProdukt in einkaufsPosition)
            {
                gesamtPreis = gesamtPreis + (einkaufsPositionsProdukt.Anzahl * einkaufsPositionsProdukt.Produkt.Preis);
            }
            return gesamtPreis;
        }

        public void Create(List<EinkaufsPosition> einkaufsposition)
        {
            Beleg beleg = new Beleg
            {
                Kaufdatum = DateTime.Now,
                Gesamtpreis = GetGesamtPreis(einkaufsposition),
                EinkaufsPosition = einkaufsposition
            };
            beleg.EinkaufsPosition.AddRange(einkaufsposition);
            context.Add(beleg);
        }
    }
}
