using Volo.Abp.Modularity;

namespace ProductCatalog;

[DependsOn(
    typeof(ProductCatalogApplicationModule),
    typeof(ProductCatalogDomainTestModule)
    )]
public class ProductCatalogApplicationTestModule : AbpModule
{

}
