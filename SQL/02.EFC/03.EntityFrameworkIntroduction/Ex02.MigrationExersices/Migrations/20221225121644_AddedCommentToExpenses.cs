using Microsoft.EntityFrameworkCore.Migrations;

namespace Ex02.MigrationExersices.Migrations
{
    public partial class AddedCommentToExpenses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "comment",
                table: "Expens",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "comment",
                table: "Expens");
        }
    }
}
