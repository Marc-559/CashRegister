using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashRegister.Models
{
    public class Beleg
    {
        [Key]
        public int Belegnummer { get; set; }
        public DateTime Kaufdatum { get; set; }
        public decimal Gesamtpreis { get; set; }
        public List<EinkaufsPosition> EinkaufsPosition { get; set; } = new List<EinkaufsPosition>();
    }
}
