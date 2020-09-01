using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class seedGrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "grades",
                columns: new[] { "IDGrade", "grade" },
                values: new object[,]
                {
                    { 1, "اول" },
                    { 2, "دوم" },
                    { 3, "سوم" },
                    { 4, "چهارم" },
                    { 5, "پنجم" },
                    { 6, "ششم" },
                    { 7, "هفتم" },
                    { 8, "هشتم" },
                    { 9, "نهم" },
                    { 10, "دهم" },
                    { 11, "یازدهم" },
                    { 12, "دوازدهم" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "grades",
                keyColumn: "IDGrade",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "grades",
                keyColumn: "IDGrade",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "grades",
                keyColumn: "IDGrade",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "grades",
                keyColumn: "IDGrade",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "grades",
                keyColumn: "IDGrade",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "grades",
                keyColumn: "IDGrade",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "grades",
                keyColumn: "IDGrade",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "grades",
                keyColumn: "IDGrade",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "grades",
                keyColumn: "IDGrade",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "grades",
                keyColumn: "IDGrade",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "grades",
                keyColumn: "IDGrade",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "grades",
                keyColumn: "IDGrade",
                keyValue: 12);
        }
    }
}
