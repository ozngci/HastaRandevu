using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaRandevu.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branslar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BransAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 12, 21, 37, 59, 94, DateTimeKind.Local).AddTicks(9875))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branslar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hastalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HastaAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HastaSoyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 12, 21, 37, 59, 95, DateTimeKind.Local).AddTicks(2508))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kurumlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KurumAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 12, 21, 37, 59, 95, DateTimeKind.Local).AddTicks(3563))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurumlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doktorlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoktorAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DoktorSoyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BransId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 12, 21, 37, 59, 95, DateTimeKind.Local).AddTicks(1287))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktorlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doktorlar_Branslar_BransId",
                        column: x => x.BransId,
                        principalTable: "Branslar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoktorKurum",
                columns: table => new
                {
                    DoktorlarId = table.Column<int>(type: "int", nullable: false),
                    KurumlarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoktorKurum", x => new { x.DoktorlarId, x.KurumlarId });
                    table.ForeignKey(
                        name: "FK_DoktorKurum_Doktorlar_DoktorlarId",
                        column: x => x.DoktorlarId,
                        principalTable: "Doktorlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoktorKurum_Kurumlar_KurumlarId",
                        column: x => x.KurumlarId,
                        principalTable: "Kurumlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branslar_BransAdi",
                table: "Branslar",
                column: "BransAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoktorKurum_KurumlarId",
                table: "DoktorKurum",
                column: "KurumlarId");

            migrationBuilder.CreateIndex(
                name: "IX_Doktorlar_BransId",
                table: "Doktorlar",
                column: "BransId");

            migrationBuilder.CreateIndex(
                name: "IX_Kurumlar_KurumAdi",
                table: "Kurumlar",
                column: "KurumAdi",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoktorKurum");

            migrationBuilder.DropTable(
                name: "Hastalar");

            migrationBuilder.DropTable(
                name: "Doktorlar");

            migrationBuilder.DropTable(
                name: "Kurumlar");

            migrationBuilder.DropTable(
                name: "Branslar");
        }
    }
}
