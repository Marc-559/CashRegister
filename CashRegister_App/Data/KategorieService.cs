using CashRegister.DAL;
using CashRegister.Models;

namespace CashRegister_App.Data
{
    public class KategorieService
    {

        static CashRegisterContextDB context = new CashRegisterContextDB();

        public Task<List<Kategorie>> GetKategorieData()
        {
            return Task.FromResult(context.Kategorie.ToList());
        }
    }
}
