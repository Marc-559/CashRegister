using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashRegister.Models
{
    public class Kategorie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string KategorieName { get; set; }
        public List<Produkt> Produkte { get; set; }
        public int MandantId { get; set; }
        public Mandant Mandant { get; set; }
    }
}
