using CashRegister.DAL;
using CashRegister.Models;

namespace CashRegister_App.Data
{
    public class VerlaufService
    {
        static CashRegisterContextDB context = new CashRegisterContextDB();

        public Task<List<Beleg>> GetVerlaufDaten()
        {
            return Task.FromResult(context.Einkauf.ToList());
        }
    }
}
