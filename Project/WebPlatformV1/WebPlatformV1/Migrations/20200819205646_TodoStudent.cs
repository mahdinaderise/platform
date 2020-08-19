using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class TodoStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tbl_TodoAppStudentId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tbl_TodoAppStudents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STudentID = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    IsFinally = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TodoAppStudents", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Tbl_TodoAppStudentId",
                table: "AspNetUsers",
                column: "Tbl_TodoAppStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Tbl_TodoAppStudents_Tbl_TodoAppStudentId",
                table: "AspNetUsers",
                column: "Tbl_TodoAppStudentId",
                principalTable: "Tbl_TodoAppStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Tbl_TodoAppStudents_Tbl_TodoAppStudentId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Tbl_TodoAppStudents");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Tbl_TodoAppStudentId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Tbl_TodoAppStudentId",
                table: "AspNetUsers");
        }
    }
}
