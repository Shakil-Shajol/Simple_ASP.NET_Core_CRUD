using Microsoft.EntityFrameworkCore.Migrations;

namespace Simple_ASP.NET_Core_CRUD.Migrations
{
    public partial class InsertGenderData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData( table: "Genders",columns: new[] { "Sex" },values: new object[] { "Male" });
            migrationBuilder.InsertData( table: "Genders",columns: new[] { "Sex" },values: new object[] { "Female" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
