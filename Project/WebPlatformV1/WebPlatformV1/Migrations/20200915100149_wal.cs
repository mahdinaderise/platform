using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class wal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tbl_Wallets_ConsultantId",
                table: "tbl_Wallets");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Wallets_ConsultantId",
                table: "tbl_Wallets",
                column: "ConsultantId",
                unique: true,
                filter: "[ConsultantId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tbl_Wallets_ConsultantId",
                table: "tbl_Wallets");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Wallets_ConsultantId",
                table: "tbl_Wallets",
                column: "ConsultantId");
        }
    }
}
