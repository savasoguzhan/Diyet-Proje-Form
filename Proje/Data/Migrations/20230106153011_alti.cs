using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace M_Proje.Data.Migrations
{
    public partial class alti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OgunTarihi",
                table: "Ogunler");

            migrationBuilder.InsertData(
                table: "Ogunler",
                columns: new[] { "Id", "Zaman" },
                values: new object[] { 1, "Sabah" });

            migrationBuilder.InsertData(
                table: "Ogunler",
                columns: new[] { "Id", "Zaman" },
                values: new object[] { 2, "Öğle" });

            migrationBuilder.InsertData(
                table: "Ogunler",
                columns: new[] { "Id", "Zaman" },
                values: new object[] { 3, "Akşam" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ogunler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ogunler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ogunler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<DateTime>(
                name: "OgunTarihi",
                table: "Ogunler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
