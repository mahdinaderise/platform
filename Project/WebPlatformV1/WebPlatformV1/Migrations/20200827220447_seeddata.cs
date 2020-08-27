using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_Courses",
                columns: new[] { "IDCourse", "NameCourse", "grade" },
                values: new object[,]
                {
                    { 3, "ادبیات", "3" },
                    { 4, "زبان فارسی", "3" },
                    { 5, "عربی", "3" },
                    { 6, "دین و زندگی", "3" },
                    { 7, "زبان انگلیسی", "3" },
                    { 8, "زمین", "3" },
                    { 9, "زیست", "3" },
                    { 10, "فیزیک", "3" },
                    { 11, "شیمی", "3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_Courses",
                keyColumn: "IDCourse",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tbl_Courses",
                keyColumn: "IDCourse",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tbl_Courses",
                keyColumn: "IDCourse",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "tbl_Courses",
                keyColumn: "IDCourse",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "tbl_Courses",
                keyColumn: "IDCourse",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "tbl_Courses",
                keyColumn: "IDCourse",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "tbl_Courses",
                keyColumn: "IDCourse",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "tbl_Courses",
                keyColumn: "IDCourse",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "tbl_Courses",
                keyColumn: "IDCourse",
                keyValue: 11);
        }
    }
}
