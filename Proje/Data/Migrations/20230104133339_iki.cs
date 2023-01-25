using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace M_Proje.Data.Migrations
{
    public partial class iki : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilar_Ogunler_OgunId",
                table: "Kullanicilar");

            migrationBuilder.DropIndex(
                name: "IX_Kullanicilar_OgunId",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "OgunId",
                table: "Kullanicilar");

            migrationBuilder.CreateTable(
                name: "KullaniciOgunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    OgunId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciOgunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciOgunler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciOgunler_Ogunler_OgunId",
                        column: x => x.OgunId,
                        principalTable: "Ogunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciOgunler_KullaniciId",
                table: "KullaniciOgunler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciOgunler_OgunId",
                table: "KullaniciOgunler",
                column: "OgunId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciOgunler");

            migrationBuilder.AddColumn<int>(
                name: "OgunId",
                table: "Kullanicilar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_OgunId",
                table: "Kullanicilar",
                column: "OgunId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilar_Ogunler_OgunId",
                table: "Kullanicilar",
                column: "OgunId",
                principalTable: "Ogunler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
