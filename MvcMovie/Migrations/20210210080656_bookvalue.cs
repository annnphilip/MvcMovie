using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class bookvalue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorInfoId",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Bookdetails_Id",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DetailsId",
                table: "Book",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BookAuthor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookvalues",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No_chapter = table.Column<int>(nullable: false),
                    No_Pages = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookvalues", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorInfoId",
                table: "Book",
                column: "AuthorInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_Bookdetails_Id",
                table: "Book",
                column: "Bookdetails_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_BookAuthor_AuthorInfoId",
                table: "Book",
                column: "AuthorInfoId",
                principalTable: "BookAuthor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Bookvalues_Bookdetails_Id",
                table: "Book",
                column: "Bookdetails_Id",
                principalTable: "Bookvalues",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_BookAuthor_AuthorInfoId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Bookvalues_Bookdetails_Id",
                table: "Book");

            migrationBuilder.DropTable(
                name: "BookAuthor");

            migrationBuilder.DropTable(
                name: "Bookvalues");

            migrationBuilder.DropIndex(
                name: "IX_Book_AuthorInfoId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_Bookdetails_Id",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "AuthorInfoId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Bookdetails_Id",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "DetailsId",
                table: "Book");
        }
    }
}
