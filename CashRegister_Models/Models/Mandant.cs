namespace CashRegister.Models
{
    public class Mandant
    {
        public int Id { get; set; }
        public string MandantName { get; set; }
        public List<Kategorie> Kategorien { get; set; }
    }
}
