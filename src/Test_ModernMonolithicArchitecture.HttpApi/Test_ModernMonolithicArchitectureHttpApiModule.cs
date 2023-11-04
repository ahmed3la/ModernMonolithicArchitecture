using Localization.Resources.AbpUi;
using Test_ModernMonolithicArchitecture.Localization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using ProductCatalog;
using ShoppingCart;

namespace Test_ModernMonolithicArchitecture;

[DependsOn(
    typeof(Test_ModernMonolithicArchitectureApplicationContractsModule),
    typeof(AbpAccountHttpApiModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpTenantManagementHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule)
    )]
[DependsOn(typeof(ProductCatalogHttpApiModule))]
    [DependsOn(typeof(ShoppingCartHttpApiModule))]
    public class Test_ModernMonolithicArchitectureHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<Test_ModernMonolithicArchitectureResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
