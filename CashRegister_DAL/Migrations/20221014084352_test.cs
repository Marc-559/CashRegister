using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CashRegister_DAL.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Belegnummer",
                table: "Einkauf",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Belegnummer",
                table: "Einkauf");
        }
    }
}
