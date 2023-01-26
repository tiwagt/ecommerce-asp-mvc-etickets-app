using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace etickets.Migrations
{
    /// <inheritdoc />
    public partial class CartItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Movies_MoviesId",
                table: "ShoppingCartItems");

            migrationBuilder.RenameColumn(
                name: "MoviesId",
                table: "ShoppingCartItems",
                newName: "movieId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_MoviesId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_movieId");

            migrationBuilder.AlterColumn<string>(
                name: "ShoppingCartId",
                table: "ShoppingCartItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Movies_movieId",
                table: "ShoppingCartItems",
                column: "movieId",
                principalTable: "Movies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Movies_movieId",
                table: "ShoppingCartItems");

            migrationBuilder.RenameColumn(
                name: "movieId",
                table: "ShoppingCartItems",
                newName: "MoviesId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_movieId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_MoviesId");

            migrationBuilder.AlterColumn<int>(
                name: "ShoppingCartId",
                table: "ShoppingCartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Movies_MoviesId",
                table: "ShoppingCartItems",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "Id");
        }
    }
}
