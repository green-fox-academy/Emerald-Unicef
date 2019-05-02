using Microsoft.EntityFrameworkCore.Migrations;

namespace Unicef.Migrations
{
    public partial class Unicef4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "Answers",
                nullable: false,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Value",
                table: "Answers",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
