using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addforeinkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookDetails_BookDetails_Id1",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookDetails_Id1",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookDetails_Id1",
                table: "Books");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookDetails_Id",
                table: "Books",
                column: "BookDetails_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookDetails_BookDetails_Id",
                table: "Books",
                column: "BookDetails_Id",
                principalTable: "BookDetails",
                principalColumn: "BookDetails_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookDetails_BookDetails_Id",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookDetails_Id",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "BookDetails_Id1",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "BookDetails_Id1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "BookDetails_Id1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "BookDetails_Id1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "BookDetails_Id1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "BookDetails_Id1",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookDetails_Id1",
                table: "Books",
                column: "BookDetails_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookDetails_BookDetails_Id1",
                table: "Books",
                column: "BookDetails_Id1",
                principalTable: "BookDetails",
                principalColumn: "BookDetails_Id");
        }
    }
}
