using CashRegister.DAL;
using CashRegister.Models;

namespace CashRegister_App.Data
{
    public class ProduktService
    {
        static CashRegisterContextDB context = new CashRegisterContextDB();
     

        public void Create(string Name, double Preis, bool Preisart, Kategorie kategorie )
        {
            Produkt produkt = new Produkt
            {
                Name = Name,
                Preis = Preis,
                Preisart = Preisart,
                Kategorie = kategorie
            };
            context.Add(produkt);
            
        }
    }
}
