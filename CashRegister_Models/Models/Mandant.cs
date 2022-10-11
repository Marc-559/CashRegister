using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister.Models
{
    public class Mandant
    {
        public int MandantId { get; set; }
        public string MandantName { get; set; }
        public List<Kategorie> Kategorien { get; set; }
    }
}
