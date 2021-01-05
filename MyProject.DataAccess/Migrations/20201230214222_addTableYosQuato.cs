using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProject.DataAccess.Migrations
{
    public partial class addTableYosQuato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_YosQuota",
                table: "YosQuota");

            migrationBuilder.RenameTable(
                name: "YosQuota",
                newName: "YosQuotas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_YosQuotas",
                table: "YosQuotas",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_YosQuotas",
                table: "YosQuotas");

            migrationBuilder.RenameTable(
                name: "YosQuotas",
                newName: "YosQuota");

            migrationBuilder.AddPrimaryKey(
                name: "PK_YosQuota",
                table: "YosQuota",
                column: "Id");
        }
    }
}
