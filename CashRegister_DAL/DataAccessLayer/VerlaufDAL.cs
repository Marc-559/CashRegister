using CashRegister.DAL;
using CashRegister_Models.Models;
using Microsoft.EntityFrameworkCore;

namespace CashRegister_DAL.DataAccessLayer
{
    public class VerlaufDAL
    {

        CashRegisterContextDB context = new CashRegisterContextDB();
        public VerlaufDAL(CashRegisterContextDB context)
        {
            this.context = context;
        }

        public List<ModelVerlauf> Create(List<ProductCount> produktcount, List<ModelVerlauf> verlaufList)
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
