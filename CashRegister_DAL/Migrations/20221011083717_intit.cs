using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CashRegister_DAL.Migrations
{
    public partial class intit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Einkauf",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gesamtpreis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Einkauf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mandant",
                columns: table => new
                {
                    MandantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MandantName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mandant", x => x.MandantId);
                });

            migrationBuilder.CreateTable(
                name: "Kategorie",
                columns: table => new
                {
                    KategorieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategorieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MandantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorie", x => x.KategorieId);
                    table.ForeignKey(
                        name: "FK_Kategorie_Mandant_MandantId",
                        column: x => x.MandantId,
                        principalTable: "Mandant",
                        principalColumn: "MandantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produkt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preis = table.Column<double>(type: "float", nullable: false),
                    Preisart = table.Column<bool>(type: "bit", nullable: false),
                    KategorieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produkt_Kategorie_KategorieId",
                        column: x => x.KategorieId,
                        principalTable: "Kategorie",
                        principalColumn: "KategorieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EinkaufsPosition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anzahl = table.Column<int>(type: "int", nullable: false),
                    EinkaufId = table.Column<int>(type: "int", nullable: false),
                    ProdukteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EinkaufsPosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EinkaufsPosition_Einkauf_EinkaufId",
                        column: x => x.EinkaufId,
                        principalTable: "Einkauf",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EinkaufsPosition_Produkt_ProdukteId",
                        column: x => x.ProdukteId,
                        principalTable: "Produkt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Mandant",
                columns: new[] { "MandantId", "MandantName" },
                values: new object[] { 1, "Gastro" });

            migrationBuilder.InsertData(
                table: "Mandant",
                columns: new[] { "MandantId", "MandantName" },
                values: new object[] { 2, "Sennerei" });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "KategorieId", "KategorieName", "MandantId" },
                values: new object[] { 1, "Käse", 2 });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "KategorieId", "KategorieName", "MandantId" },
                values: new object[] { 2, "Getränk", 1 });

            migrationBuilder.InsertData(
                table: "Produkt",
                columns: new[] { "Id", "KategorieId", "Name", "Preis", "Preisart" },
                values: new object[] { 1, 1, "Bergkäse", 20.5, true });

            migrationBuilder.InsertData(
                table: "Produkt",
                columns: new[] { "Id", "KategorieId", "Name", "Preis", "Preisart" },
                values: new object[] { 2, 2, "Kellerbier", 5.0, false });

            migrationBuilder.CreateIndex(
                name: "IX_EinkaufsPosition_EinkaufId",
                table: "EinkaufsPosition",
                column: "EinkaufId");

            migrationBuilder.CreateIndex(
                name: "IX_EinkaufsPosition_ProdukteId",
                table: "EinkaufsPosition",
                column: "ProdukteId");

            migrationBuilder.CreateIndex(
                name: "IX_Kategorie_MandantId",
                table: "Kategorie",
                column: "MandantId");

            migrationBuilder.CreateIndex(
                name: "IX_Produkt_KategorieId",
                table: "Produkt",
                column: "KategorieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EinkaufsPosition");

            migrationBuilder.DropTable(
                name: "Einkauf");

            migrationBuilder.DropTable(
                name: "Produkt");

            migrationBuilder.DropTable(
                name: "Kategorie");

            migrationBuilder.DropTable(
                name: "Mandant");
        }
    }
}
