using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProject.DataAccess.Migrations
{
    public partial class UniverstyURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Universities",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URL",
                table: "Universities");
        }
    }
}
