using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCart.Migrations
{
    /// <inheritdoc />
    public partial class modifyShoppingCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                schema: "ShoppingCart",
                table: "ShoppingCartItems");

            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                schema: "ShoppingCart",
                table: "ShoppingCartItems",
                newName: "Price");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                schema: "ShoppingCart",
                table: "ShoppingCartItems",
                newName: "TotalPrice");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                schema: "ShoppingCart",
                table: "ShoppingCartItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
