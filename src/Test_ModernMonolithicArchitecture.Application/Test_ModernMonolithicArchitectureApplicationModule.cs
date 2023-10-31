using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using ProductCatalog;

namespace Test_ModernMonolithicArchitecture;

[DependsOn(
    typeof(Test_ModernMonolithicArchitectureDomainModule),
    //typeof(AbpAccountApplicationModule),
    typeof(Test_ModernMonolithicArchitectureApplicationContractsModule)
    //typeof(AbpIdentityApplicationModule),
    //typeof(AbpPermissionManagementApplicationModule),
    //typeof(AbpTenantManagementApplicationModule),
    //typeof(AbpFeatureManagementApplicationModule),
    //typeof(AbpSettingManagementApplicationModule)
    )]
[DependsOn(typeof(ProductCatalogApplicationModule))]
    public class Test_ModernMonolithicArchitectureApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<Test_ModernMonolithicArchitectureApplicationModule>();
        });
    }
}
