using Microsoft.EntityFrameworkCore.Migrations;

namespace Unicef.Migrations
{
    public partial class Unicef3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<long>(
                name: "FormId",
                table: "Queries",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "QuizId",
                table: "Queries",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Queries_FormId",
                table: "Queries",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_Queries_QuizId",
                table: "Queries",
                column: "QuizId");

            migrationBuilder.AddForeignKey(
                name: "FK_Queries_Forms_FormId",
                table: "Queries",
                column: "FormId",
                principalTable: "Forms",
                principalColumn: "FormId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Queries_Quizes_QuizId",
                table: "Queries",
                column: "QuizId",
                principalTable: "Quizes",
                principalColumn: "QuizId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Queries_Forms_FormId",
                table: "Queries");

            migrationBuilder.DropForeignKey(
                name: "FK_Queries_Quizes_QuizId",
                table: "Queries");

            migrationBuilder.DropIndex(
                name: "IX_Queries_FormId",
                table: "Queries");

            migrationBuilder.DropIndex(
                name: "IX_Queries_QuizId",
                table: "Queries");

            migrationBuilder.DropColumn(
                name: "FormId",
                table: "Queries");

            migrationBuilder.DropColumn(
                name: "QuizId",
                table: "Queries");

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
    }
}
