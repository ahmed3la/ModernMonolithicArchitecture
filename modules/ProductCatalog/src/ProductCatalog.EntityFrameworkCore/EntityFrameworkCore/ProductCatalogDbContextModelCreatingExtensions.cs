using Microsoft.EntityFrameworkCore;
using ProductCatalog.Mappings;
using System.Reflection.Emit;
using Volo.Abp;

namespace ProductCatalog.EntityFrameworkCore;

public static class ProductCatalogDbContextModelCreatingExtensions
{
    public static void ConfigureProductCatalog(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.ApplyConfiguration(new Mappings.ProductMapping());

 
    }
}
