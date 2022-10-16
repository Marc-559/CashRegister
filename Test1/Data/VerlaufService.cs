using CashRegister.DAL;
using CashRegister.Models;

namespace Test1.Data
{
    public class VerlaufService
    {
        static CashRegisterContextDB context = new CashRegisterContextDB();

        public Task<List<Einkauf>> GetVerlaufDaten()
        {
            return Task.FromResult(context.Einkauf.ToList());
        }


    }
}
