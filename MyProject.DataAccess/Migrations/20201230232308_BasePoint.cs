using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProject.DataAccess.Migrations
{
    public partial class BasePoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "basePoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstCities = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SecondCities = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ThirdCities = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_basePoints", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "basePoints");
        }
    }
}
