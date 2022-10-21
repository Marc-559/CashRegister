using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister.Models
{
    public class Beleg
    {
        [Key]
        public int Belegnummer { get; set; }
        public DateTime Kaufdatum { get; set; }
        public string Gesamtpreis { get; set; }
        public List<EinkaufsPosition> EinkaufsPosition { get; set; }

        public string displayDatum()
        {
            return Kaufdatum.ToShortDateString();
        }

    }
}
