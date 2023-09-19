using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Library.DataLayer.Migrations
{
    public partial class LibraryCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
        name: "BookLists",
        columns: table => new
        {
            BookID = table.Column<int>(nullable: false)
                .Annotation("SqlServer:Identity", "1, 1"),
            BookName = table.Column<string>(nullable: true),
            Author = table.Column<string>(nullable: true),
            NumberOfPages = table.Column<int>(nullable: false),
            PublicationDate = table.Column<int>(nullable: false),
            Publisher = table.Column<string>(nullable: true)
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_BookLists", x => x.BookID);
        });
    }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
       name: "BookLists");
        }
    }
}
