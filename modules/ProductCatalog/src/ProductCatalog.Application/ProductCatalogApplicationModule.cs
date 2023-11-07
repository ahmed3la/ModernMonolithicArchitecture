using Microsoft.Extensions.DependencyInjection;
using SharedCaching;
using SharedCaching.CachingProducts;
using SharedCaching.ICachingProducts;
using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace ProductCatalog;

[DependsOn(
    typeof(ProductCatalogDomainModule),
    typeof(ProductCatalogApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule),
    typeof(CachingModule)
    )]
public class ProductCatalogApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddScoped<ICachingProduct, CachingProduct>(); 


        context.Services.AddAutoMapperObjectMapper<ProductCatalogApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<ProductCatalogApplicationModule>(validate: true);
        });

    }

     


}
