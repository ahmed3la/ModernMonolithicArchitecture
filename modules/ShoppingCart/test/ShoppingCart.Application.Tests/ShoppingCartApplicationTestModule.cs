using Volo.Abp.Modularity;

namespace ShoppingCart;

[DependsOn(
    typeof(ShoppingCartApplicationModule),
    typeof(ShoppingCartDomainTestModule)
    )]
public class ShoppingCartApplicationTestModule : AbpModule
{

}
