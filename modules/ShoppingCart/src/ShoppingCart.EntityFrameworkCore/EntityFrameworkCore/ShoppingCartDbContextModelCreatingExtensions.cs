using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace ShoppingCart.EntityFrameworkCore;

public static class ShoppingCartDbContextModelCreatingExtensions
{
    public static void ConfigureShoppingCart(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
         
        builder.ApplyConfiguration(new Mappings.CartMapping());
        builder.ApplyConfiguration(new Mappings.ShoppingCartItemMapping());
    }
}
