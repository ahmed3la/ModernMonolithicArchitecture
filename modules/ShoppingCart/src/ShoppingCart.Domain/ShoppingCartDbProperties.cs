namespace ShoppingCart;

public static class ShoppingCartDbProperties
{
    public static string DbTablePrefix { get; set; } = "ShoppingCart";

    public static string? DbSchema { get; set; } = "ShoppingCart";

    public const string ConnectionStringName = "ShoppingCart";
}
