using Microsoft.EntityFrameworkCore.Migrations;

namespace Unicef.Migrations
{
    public partial class Unicef2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "QueryId1",
                table: "Quizes",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "QueryId1",
                table: "Forms",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quizes_QueryId1",
                table: "Quizes",
                column: "QueryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_QueryId1",
                table: "Forms",
                column: "QueryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Forms_Queries_QueryId1",
                table: "Forms",
                column: "QueryId1",
                principalTable: "Queries",
                principalColumn: "QueryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quizes_Queries_QueryId1",
                table: "Quizes",
                column: "QueryId1",
                principalTable: "Queries",
                principalColumn: "QueryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forms_Queries_QueryId1",
                table: "Forms");

            migrationBuilder.DropForeignKey(
                name: "FK_Quizes_Queries_QueryId1",
                table: "Quizes");

            migrationBuilder.DropIndex(
                name: "IX_Quizes_QueryId1",
                table: "Quizes");

            migrationBuilder.DropIndex(
                name: "IX_Forms_QueryId1",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "QueryId1",
                table: "Quizes");

            migrationBuilder.DropColumn(
                name: "QueryId1",
                table: "Forms");
        }
    }
}
