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

        public List<Beleg> GetBelege()
        {
            return context.Einkauf.ToList();
        }

    }
}
