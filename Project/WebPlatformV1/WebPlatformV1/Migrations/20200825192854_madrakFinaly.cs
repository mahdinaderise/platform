using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class madrakFinaly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SendDegree_AspNetUsers_ConsultantId",
                table: "SendDegree");

            migrationBuilder.DropIndex(
                name: "IX_SendDegree_ConsultantId",
                table: "SendDegree");

            migrationBuilder.AlterColumn<string>(
                name: "ConsultantId",
                table: "SendDegree",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "sendDegreeId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_sendDegreeId",
                table: "AspNetUsers",
                column: "sendDegreeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SendDegree_sendDegreeId",
                table: "AspNetUsers",
                column: "sendDegreeId",
                principalTable: "SendDegree",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SendDegree_sendDegreeId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_sendDegreeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "sendDegreeId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "ConsultantId",
                table: "SendDegree",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SendDegree_ConsultantId",
                table: "SendDegree",
                column: "ConsultantId",
                unique: true,
                filter: "[ConsultantId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_SendDegree_AspNetUsers_ConsultantId",
                table: "SendDegree",
                column: "ConsultantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
