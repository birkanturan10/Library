using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.DataLayer.Migrations
{
    public partial class LibraryCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorBooks",
                table: "BookLists");

            migrationBuilder.DropColumn(
                name: "PublisherBooks",
                table: "BookLists");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorBooks",
                table: "BookLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PublisherBooks",
                table: "BookLists",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
