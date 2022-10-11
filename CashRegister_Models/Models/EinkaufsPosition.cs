using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister.Models
{
    public class EinkaufsPosition
    {
        public int Id { get; set; }
        public int Anzahl { get; set; }
        public Einkauf Einkauf { get; set; }
        public Produkt Produkte { get; set; }
    }
}
