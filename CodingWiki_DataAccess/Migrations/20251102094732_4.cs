using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Books_BookDetails_Id",
                table: "Books");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookDetails_Id",
                table: "Books",
                column: "BookDetails_Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Books_BookDetails_Id",
                table: "Books");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookDetails_Id",
                table: "Books",
                column: "BookDetails_Id");
        }
    }
}
