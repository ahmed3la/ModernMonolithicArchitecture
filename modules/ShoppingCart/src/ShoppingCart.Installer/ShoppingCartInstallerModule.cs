using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ShoppingCart;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class ShoppingCartInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ShoppingCartInstallerModule>();
        });
    }
}
