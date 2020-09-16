using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class seedD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tbl_Comisions",
                columns: new[] { "Id", "percent", "price" },
                values: new object[] { 3, 0, 5000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tbl_Comisions",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
