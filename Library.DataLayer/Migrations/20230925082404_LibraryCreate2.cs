using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.DataLayer.Migrations
{
    public partial class LibraryCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorBooks",
                table: "BookLists",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PublisherBooks",
                table: "BookLists",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorBooks",
                table: "BookLists");

            migrationBuilder.DropColumn(
                name: "PublisherBooks",
                table: "BookLists");
        }
    }
}
