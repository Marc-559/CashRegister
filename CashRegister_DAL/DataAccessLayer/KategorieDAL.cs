using CashRegister.DAL;
using CashRegister.Models;

namespace CashRegister_DAL.DataAccessLayer
{
    public class KategorieDAL
    {
        CashRegisterContextDB context;
        public KategorieDAL(CashRegisterContextDB context)
        {
            this.context = context;
        }

        //Holt alle Belege aus der Dtaenbank und gibt sie zurück
        public Task<List<Kategorie>> GetKategorien()
        {
            return Task.FromResult(context.Kategorie.ToList());
        }
    }
}
