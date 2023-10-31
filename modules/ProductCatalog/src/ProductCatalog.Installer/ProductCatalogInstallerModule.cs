using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ProductCatalog;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class ProductCatalogInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ProductCatalogInstallerModule>();
        });
    }
}
