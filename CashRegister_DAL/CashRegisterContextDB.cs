using CashRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace CashRegister.DAL
{
    public class CashRegisterContextDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CashRegisterDB;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mandant>().HasData(
              new Mandant { Id = 1, MandantName = "Gastro" },
              new Mandant { Id= 2, MandantName = "Sennerei" }
              );

            modelBuilder.Entity<Kategorie>().HasData(

                // Sennerei Kategorieen 
                new Kategorie { Id = 1, KategorieName = "Käse", MandantId = 2 },
                new Kategorie { Id = 2, KategorieName = "Joghurt", MandantId = 2 },
                new Kategorie { Id = 3, KategorieName = "Butter", MandantId = 2 },
                new Kategorie { Id = 4, KategorieName = "Sonstiges", MandantId = 2 },

                // Gastro Kategorie
                new Kategorie { Id = 5, KategorieName = "Alc.Getränke", MandantId = 1 },
                new Kategorie { Id = 6, KategorieName = "Non.Alc.Getränke", MandantId = 1 },
                new Kategorie { Id = 7, KategorieName = "Speisen", MandantId = 1 }
                );

            //Preisart = true (Kg Preis) Preisart = false (Fixpreis)
            modelBuilder.Entity<Produkt>().HasData(

                // Sennerei Kategorie
                // Käse
                new Produkt { Id = 1, Name = "Mutschli", Preis = 22.00, Preisart = true, KategorieId = 1 },
                new Produkt { Id = 2, Name = "Alpkäs", Preis = 20.50, Preisart = true, KategorieId = 1 },
                new Produkt { Id = 3, Name = "Ziger/Ricotta", Preis = 22.00, Preisart = true, KategorieId = 1 },
                // Joghurt
                new Produkt { Id = 4, Name = "Fruchtjoghurt", Preis = 2.60, Preisart = false, KategorieId = 2 },
                new Produkt { Id = 5, Name = "Naturjoghurt", Preis = 2.00, Preisart = false, KategorieId = 2 },
                // Butter
                new Produkt { Id = 6, Name = "Modelbutter", Preis = 6.00, Preisart = false, KategorieId = 3 },
                //Sonstiges
                new Produkt { Id = 7, Name = "Molke", Preis = 2.00, Preisart = false, KategorieId = 4 },
                new Produkt { Id = 8, Name = "Alpkäs", Preis = 2.00, Preisart = false, KategorieId = 4 },

                // Gastro Kategorie
                // Alc.Getränke
                new Produkt { Id = 9, Name = "Bier Gr.", Preis = 5.00, Preisart = false, KategorieId = 5 },
                new Produkt { Id = 10, Name = "Bier Kl.", Preis = 4.50, Preisart = false, KategorieId = 5 },
                new Produkt { Id = 11, Name = "Most 5cl", Preis = 5.00, Preisart = false, KategorieId = 5 },
                new Produkt { Id = 12, Name = "Most 3cl", Preis = 3.50, Preisart = false, KategorieId = 5 },
                // Non.Alc.Getränke
                new Produkt { Id = 13, Name = "Limo 33cl", Preis = 4.50, Preisart = false, KategorieId = 6 },
                new Produkt { Id = 14, Name = "Mineral 33cl", Preis = 4.50, Preisart = false, KategorieId = 6 },
                new Produkt { Id = 15, Name = "Kaffee", Preis = 4.00, Preisart = false, KategorieId = 6 },
                new Produkt { Id = 16, Name = "Kafi Lutz", Preis = 6.00, Preisart = false, KategorieId = 6 },
                // Speisen
                new Produkt { Id = 17, Name = "Portion Käse", Preis = 8.00, Preisart = false, KategorieId = 7 },
                new Produkt { Id = 18, Name = "Wurst-Käsesalat", Preis = 12.00, Preisart = false, KategorieId = 7 },
                new Produkt { Id = 19, Name = "Salsiz", Preis = 8.00, Preisart = false, KategorieId = 7 },
                new Produkt { Id = 20, Name = "Salsiz mit Käse", Preis = 12.00, Preisart = false, KategorieId = 7 },
                new Produkt { Id = 21, Name = "Buurawurst", Preis = 7.00, Preisart = false, KategorieId = 7 },
                new Produkt { Id = 22, Name = "Käseschnitte", Preis = 7.00, Preisart = false, KategorieId = 7 }
                );
        }

        public DbSet<Produkt> Produkt { get; set; }
        public DbSet<Beleg> Einkauf { get; set; }
        public DbSet<EinkaufsPosition> EinkaufsPosition { get; set; }
        public DbSet<Kategorie> Kategorie { get; set; }
        public DbSet<Mandant> Mandant { get; set; }


    }
}