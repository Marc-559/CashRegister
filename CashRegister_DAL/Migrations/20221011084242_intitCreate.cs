using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CashRegister_DAL.Migrations
{
    public partial class intitCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kategorie",
                keyColumn: "KategorieId",
                keyValue: 2,
                columns: new[] { "KategorieName", "MandantId" },
                values: new object[] { "Joghurt", 2 });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "KategorieId", "KategorieName", "MandantId" },
                values: new object[,]
                {
                    { 3, "Butter", 2 },
                    { 4, "Sonstiges", 2 },
                    { 5, "Alc.Getränke", 1 },
                    { 6, "Non.Alc.Getränke", 1 },
                    { 7, "Speisen", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Preis" },
                values: new object[] { "Mutschli", 22.0 });

            migrationBuilder.UpdateData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KategorieId", "Name", "Preis", "Preisart" },
                values: new object[] { 1, "Alpkäs", 20.5, true });

            migrationBuilder.InsertData(
                table: "Produkt",
                columns: new[] { "Id", "KategorieId", "Name", "Preis", "Preisart" },
                values: new object[,]
                {
                    { 3, 1, "Ziger/Ricotta", 22.0, true },
                    { 4, 2, "Fruchtjoghurt", 2.6000000000000001, false },
                    { 5, 2, "Naturjoghurt", 2.0, false }
                });

            migrationBuilder.InsertData(
                table: "Produkt",
                columns: new[] { "Id", "KategorieId", "Name", "Preis", "Preisart" },
                values: new object[,]
                {
                    { 6, 3, "Modelbutter", 6.0, false },
                    { 7, 4, "Molke", 2.0, false },
                    { 8, 4, "Alpkäs", 2.0, false },
                    { 9, 5, "Bier Gr.", 5.0, false },
                    { 10, 5, "Bier Kl.", 4.5, false },
                    { 11, 5, "Most 5cl", 5.0, false },
                    { 12, 5, "Most 3cl", 3.5, false },
                    { 13, 6, "Limo 33cl", 4.5, false },
                    { 14, 6, "Mineral 33cl", 4.5, false },
                    { 15, 6, "Kaffee", 4.0, false },
                    { 16, 6, "Kafi Lutz", 6.0, false },
                    { 17, 7, "Portion Käse", 8.0, false },
                    { 18, 7, "Wurst-Käsesalat", 12.0, false },
                    { 19, 7, "Salsiz", 8.0, false },
                    { 20, 7, "Salsiz mit Käse", 12.0, false },
                    { 21, 7, "Buurawurst", 7.0, false },
                    { 22, 7, "Käseschnitte", 7.0, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Kategorie",
                keyColumn: "KategorieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kategorie",
                keyColumn: "KategorieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kategorie",
                keyColumn: "KategorieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Kategorie",
                keyColumn: "KategorieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Kategorie",
                keyColumn: "KategorieId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Kategorie",
                keyColumn: "KategorieId",
                keyValue: 2,
                columns: new[] { "KategorieName", "MandantId" },
                values: new object[] { "Getränk", 1 });

            migrationBuilder.UpdateData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Preis" },
                values: new object[] { "Bergkäse", 20.5 });

            migrationBuilder.UpdateData(
                table: "Produkt",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KategorieId", "Name", "Preis", "Preisart" },
                values: new object[] { 2, "Kellerbier", 5.0, false });
        }
    }
}
