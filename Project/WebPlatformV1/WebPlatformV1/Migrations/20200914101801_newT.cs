using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class newT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tbl_RequestPeymentid",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tbl_RequestPeyment",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<string>(nullable: true),
                    Shaba = table.Column<string>(nullable: true),
                    IsPey = table.Column<bool>(nullable: false),
                    Descrontion = table.Column<string>(nullable: true),
                    refid = table.Column<long>(nullable: false),
                    MyProperty = table.Column<int>(nullable: false),
                    ConsultantID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_RequestPeyment", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Tbl_RequestPeymentid",
                table: "AspNetUsers",
                column: "Tbl_RequestPeymentid");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Tbl_RequestPeyment_Tbl_RequestPeymentid",
                table: "AspNetUsers",
                column: "Tbl_RequestPeymentid",
                principalTable: "Tbl_RequestPeyment",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Tbl_RequestPeyment_Tbl_RequestPeymentid",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Tbl_RequestPeyment");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Tbl_RequestPeymentid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Tbl_RequestPeymentid",
                table: "AspNetUsers");
        }
    }
}
