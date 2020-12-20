using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProject.DataAccess.Migrations
{
    public partial class addOthersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Universities_AspNetUsers_AppUserId",
                table: "Universities");

            migrationBuilder.DropIndex(
                name: "IX_Universities_AppUserId",
                table: "Universities");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Universities");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Universities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UniversityTypeId",
                table: "Universities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AppUserUniversity",
                columns: table => new
                {
                    UniversitiesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserUniversity", x => new { x.UniversitiesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_AppUserUniversity_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserUniversity_Universities_UniversitiesId",
                        column: x => x.UniversitiesId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UniversityTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Universities_CityId",
                table: "Universities",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Universities_UniversityTypeId",
                table: "Universities",
                column: "UniversityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserUniversity_UsersId",
                table: "AppUserUniversity",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Universities_Cities_CityId",
                table: "Universities",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Universities_UniversityTypes_UniversityTypeId",
                table: "Universities",
                column: "UniversityTypeId",
                principalTable: "UniversityTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Universities_Cities_CityId",
                table: "Universities");

            migrationBuilder.DropForeignKey(
                name: "FK_Universities_UniversityTypes_UniversityTypeId",
                table: "Universities");

            migrationBuilder.DropTable(
                name: "AppUserUniversity");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "UniversityTypes");

            migrationBuilder.DropIndex(
                name: "IX_Universities_CityId",
                table: "Universities");

            migrationBuilder.DropIndex(
                name: "IX_Universities_UniversityTypeId",
                table: "Universities");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Universities");

            migrationBuilder.DropColumn(
                name: "UniversityTypeId",
                table: "Universities");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Universities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Universities_AppUserId",
                table: "Universities",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Universities_AspNetUsers_AppUserId",
                table: "Universities",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
