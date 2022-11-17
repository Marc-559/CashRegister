using CashRegister.DAL;
using CashRegister.Models;

namespace CashRegister_DAL.DataAccessLayer
{
    public class ProduktDAL
    {
        CashRegisterContextDB context;
        public ProduktDAL(CashRegisterContextDB context)
        {
            this.context = context;
        }

        //Erstelt ein neues Produkt mit den übergebenen Werten
        public void Create(string Name, decimal Preis, bool Preisart, Kategorie kategorie)
        {
            Produkt produkt = new Produkt
            {
                Name = Name,
                Preis = Preis,
                Preisart = Preisart,
                KategorieId = kategorie.Id,
                Kategorie = kategorie
            };
            context.Add(produkt);
        }
    }
}
