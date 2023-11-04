using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ShoppingCart;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ShoppingCartHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ShoppingCartConsoleApiClientModule : AbpModule
{

}
