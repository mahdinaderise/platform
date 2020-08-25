using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class tbl_todoappcunsoltantf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tbl_TodoAppConsultantId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tbl_TodoAppConsultant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsultantID = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    IsFinally = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TodoAppConsultant", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Tbl_TodoAppConsultantId",
                table: "AspNetUsers",
                column: "Tbl_TodoAppConsultantId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Tbl_TodoAppConsultant_Tbl_TodoAppConsultantId",
                table: "AspNetUsers",
                column: "Tbl_TodoAppConsultantId",
                principalTable: "Tbl_TodoAppConsultant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Tbl_TodoAppConsultant_Tbl_TodoAppConsultantId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Tbl_TodoAppConsultant");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Tbl_TodoAppConsultantId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Tbl_TodoAppConsultantId",
                table: "AspNetUsers");
        }
    }
}
