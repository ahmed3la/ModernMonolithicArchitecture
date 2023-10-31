using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace ProductCatalog;

[DependsOn(
    typeof(ProductCatalogDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class ProductCatalogApplicationContractsModule : AbpModule
{

}
