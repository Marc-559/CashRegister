using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister.Models
{
    public class EinkaufsPosition
    {
        public int Id { get; set; }
        public int Anzahl { get; set; }
        [Required]
        public Beleg Beleg { get; set; }
        public Produkt Produkt { get; set; }

        //Holt den Preis von den Produkten (z.b 2 * 2€ = 4€) 
        public double GetPreis()
        {
            return Anzahl * Produkt.Preis;
        }
    }
}
