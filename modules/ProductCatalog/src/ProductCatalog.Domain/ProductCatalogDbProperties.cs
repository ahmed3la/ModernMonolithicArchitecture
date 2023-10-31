namespace ProductCatalog;

public static class ProductCatalogDbProperties
{
    public static string DbTablePrefix { get; set; } = "ProductCatalog";

    public static string DbSchema { get; set; } = "Catalog";

    public const string ConnectionStringName = "ProductCatalog";
}
