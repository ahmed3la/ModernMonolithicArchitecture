using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ShoppingCart;

[DependsOn(
    typeof(ShoppingCartApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class ShoppingCartHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ShoppingCartApplicationContractsModule).Assembly,
            ShoppingCartRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ShoppingCartHttpApiClientModule>();
        });

    }
}
