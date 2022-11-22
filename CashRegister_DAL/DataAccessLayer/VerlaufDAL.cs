using CashRegister.DAL;
using CashRegister_Models.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace CashRegister_DAL.DataAccessLayer
{
    public class VerlaufDAL
    {
        CashRegisterContextDB context = new CashRegisterContextDB();
        public VerlaufDAL(CashRegisterContextDB context)
        {
            this.context = context;
        }

        //ModelVerlauf wird erstellt
        public ObservableCollection<ModelVerlauf> Create(List<ProductCount> produktcount, ObservableCollection<ModelVerlauf> verlaufList)
        {
            foreach (ProductCount produkt in produktcount)
            {
                ModelVerlauf verlauf = new ModelVerlauf
                {
                    ProduktName = produkt.product.Name,
                    Anzahl = produkt.Anzahl,
                    Gesamtpreis = (produkt.Anzahl * produkt.product.Preis),
                };
                verlaufList.Add(verlauf);
            }
            return verlaufList;
        }

        //Holt alle Produkte mit dem übergebenen Mandant (Sennerei oder Gastro)
        public List<ProductCount> GetProduktCountMandant(int mandantID, DateTime? start, DateTime? end)
        {
            //Rückgabe: Gibt die Anzahl der jeweiligen Produkte zurück
            List<ProductCount> productcount = context.EinkaufsPosition
                .Include(y => y.Produkt)
                .ThenInclude(x => x.Kategorie.Mandant)
                .Where(x => x.Beleg.Kaufdatum >= start && x.Beleg.Kaufdatum <= end)
                .AsEnumerable()
                .GroupBy(x => x.Produkt)
                .Where(x => x.Key.Kategorie.MandantId == mandantID)
                .Select(g => new ProductCount { product = g.Key, Anzahl = g.Sum(s => s.Anzahl) })
                .ToList();

            return productcount;
        }

        //Holt alle Produkte
        public List<ProductCount> GetProduktCountAll(DateTime? start, DateTime? end)
        {
            //Rückgabe: Gibt die Anzahl der jeweiligen Produkte zurück
            List<ProductCount> productcount = context.EinkaufsPosition
                .Where(x => x.Beleg.Kaufdatum >= start && x.Beleg.Kaufdatum <= end)
                .AsEnumerable()
                .GroupBy(x => x.Produkt)
                .Select(g => new ProductCount { product = g.Key, Anzahl = g.Sum(s => s.Anzahl) })
                .ToList();

            return productcount;
        }
    }
}
