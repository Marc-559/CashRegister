using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CashRegister_DAL.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Belegnummer",
                table: "Einkauf",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Kaufdatum",
                table: "Einkauf",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Belegnummer",
                table: "Einkauf");

            migrationBuilder.DropColumn(
                name: "Kaufdatum",
                table: "Einkauf");
        }
    }
}
