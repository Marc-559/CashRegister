using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashRegister.Models
{
    public class Beleg
    {
        [Key]
        public int Belegnummer { get; set; }
        public DateTime Kaufdatum { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Gesamtpreis { get; set; }
        public List<EinkaufsPosition> EinkaufsPosition { get; set; } = new List<EinkaufsPosition>();

        //Methode um das kaufdatum nur als Datum anzeigen zu lassen (Funktioniert nicht, Kann in eine andere Klasse versetzt werden)
        public string displayDatum()
        {
            return Kaufdatum.ToShortDateString();
        }

    }
}
