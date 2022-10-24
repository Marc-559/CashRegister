using CashRegister.DAL;
using CashRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_DAL.DataAccessLayer
{

    public class KategorieDAL
    {

        CashRegisterContextDB context;
        public KategorieDAL(CashRegisterContextDB context)
        {
            this.context = context;
        }

        public Task<List<Kategorie>> GetKategorien()
        {
            return Task.FromResult(context.Kategorie.ToList());
        }
    }
}
