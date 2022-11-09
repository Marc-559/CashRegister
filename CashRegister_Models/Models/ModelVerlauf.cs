using CashRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_Models.Models
{
    public class ModelVerlauf
    {
        public string ProduktName { get; set; } // Produkt Name
        public int Anzahl { get; set; } // Anzahl der Produkte die insgesamt gekauft wurden
        public double Gesamtpreis { get; set; } // Alle EInkaufspositionen Preise zusammen
    }
}
