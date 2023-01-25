using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace M_Proje.Data.Migrations
{
    public partial class Yedi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciOgunler");

            migrationBuilder.CreateTable(
                name: "KullaniciOgun",
                columns: table => new
                {
                    KullanicilarId = table.Column<int>(type: "int", nullable: false),
                    OgunlerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciOgun", x => new { x.KullanicilarId, x.OgunlerId });
                    table.ForeignKey(
                        name: "FK_KullaniciOgun_Kullanicilar_KullanicilarId",
                        column: x => x.KullanicilarId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciOgun_Ogunler_OgunlerId",
                        column: x => x.OgunlerId,
                        principalTable: "Ogunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciOgun_OgunlerId",
                table: "KullaniciOgun",
                column: "OgunlerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciOgun");

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
    }
}
