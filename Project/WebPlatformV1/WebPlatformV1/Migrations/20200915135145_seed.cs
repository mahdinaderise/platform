using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "Tbl_Comisions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Tbl_Comisions",
                columns: new[] { "Id", "percent", "price" },
                values: new object[] { 2, 0, 45000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tbl_Comisions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "price",
                table: "Tbl_Comisions");
        }
    }
}
