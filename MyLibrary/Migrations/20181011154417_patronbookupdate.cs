using Microsoft.EntityFrameworkCore.Migrations;

namespace MyLibrary.Migrations
{
    public partial class patronbookupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Library_Patron_PatronId",
                table: "Library");

            migrationBuilder.DropForeignKey(
                name: "FK_Patron_Book_BookId",
                table: "Patron");

            migrationBuilder.DropIndex(
                name: "IX_Library_PatronId",
                table: "Library");

            migrationBuilder.DropColumn(
                name: "PatronId",
                table: "Library");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Patron",
                newName: "LibraryId");

            migrationBuilder.RenameIndex(
                name: "IX_Patron_BookId",
                table: "Patron",
                newName: "IX_Patron_LibraryId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Patron",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Patron",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatronId",
                table: "Book",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_PatronId",
                table: "Book",
                column: "PatronId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Patron_PatronId",
                table: "Book",
                column: "PatronId",
                principalTable: "Patron",
                principalColumn: "PatronId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Patron_Library_LibraryId",
                table: "Patron",
                column: "LibraryId",
                principalTable: "Library",
                principalColumn: "LibraryId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Patron_PatronId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Patron_Library_LibraryId",
                table: "Patron");

            migrationBuilder.DropIndex(
                name: "IX_Book_PatronId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "PatronId",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "LibraryId",
                table: "Patron",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Patron_LibraryId",
                table: "Patron",
                newName: "IX_Patron_BookId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Patron",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Patron",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "PatronId",
                table: "Library",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Library_PatronId",
                table: "Library",
                column: "PatronId");

            migrationBuilder.AddForeignKey(
                name: "FK_Library_Patron_PatronId",
                table: "Library",
                column: "PatronId",
                principalTable: "Patron",
                principalColumn: "PatronId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Patron_Book_BookId",
                table: "Patron",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
