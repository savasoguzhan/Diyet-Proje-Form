using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace M_Proje.Data.Migrations
{
    public partial class bes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Boy",
                table: "Kullanicilar",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Kilo",
                table: "Kullanicilar",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Boy",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Kilo",
                table: "Kullanicilar");
        }
    }
}
