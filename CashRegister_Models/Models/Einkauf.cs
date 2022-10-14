using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister.Models
{
    public class Einkauf
    {
        public int Id { get; set; }
        public int Belegnummer { get; set; }
        public DateOnly Kaufdatum { get; set; }
        public string Gesamtpreis { get; set; }
        public List<EinkaufsPosition> EinkaufsPosition { get; set; }
    }
}
