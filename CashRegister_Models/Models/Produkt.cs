using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashRegister.Models
{
    public class Produkt
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(3,2)")]
        public decimal Preis { get; set; }
        public bool Preisart { get; set; }
        public List<EinkaufsPosition> EinkaufsPositionen { get; set; }
        public int KategorieId { get; set; }
        public Kategorie Kategorie { get; set; }

    }
}
