using ShoppingCart.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ShoppingCart;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(ShoppingCartEntityFrameworkCoreTestModule)
    )]
public class ShoppingCartDomainTestModule : AbpModule
{

}
