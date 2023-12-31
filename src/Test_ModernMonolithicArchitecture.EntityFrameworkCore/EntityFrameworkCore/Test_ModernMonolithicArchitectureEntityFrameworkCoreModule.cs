using System;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Uow;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using ProductCatalog.EntityFrameworkCore;
using ShoppingCart.EntityFrameworkCore;

namespace Test_ModernMonolithicArchitecture.EntityFrameworkCore;

[DependsOn(
    typeof(Test_ModernMonolithicArchitectureDomainModule),
    //typeof(AbpIdentityEntityFrameworkCoreModule),
    //typeof(AbpOpenIddictEntityFrameworkCoreModule),
    //typeof(AbpPermissionManagementEntityFrameworkCoreModule),
    //typeof(AbpSettingManagementEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCoreSqlServerModule)
    //typeof(AbpBackgroundJobsEntityFrameworkCoreModule),
    //typeof(AbpAuditLoggingEntityFrameworkCoreModule),
    //typeof(AbpTenantManagementEntityFrameworkCoreModule),
    //typeof(AbpFeatureManagementEntityFrameworkCoreModule)
    )]
[DependsOn(typeof(ProductCatalogEntityFrameworkCoreModule))]
    [DependsOn(typeof(ShoppingCartEntityFrameworkCoreModule))]
    public class Test_ModernMonolithicArchitectureEntityFrameworkCoreModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        Test_ModernMonolithicArchitectureEfCoreEntityExtensionMappings.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        //context.Services.AddAbpDbContext<Test_ModernMonolithicArchitectureDbContext>(options =>
        //{
        //        /* Remove "includeAllEntities: true" to create
        //         * default repositories only for aggregate roots */
        //    //options.AddDefaultRepositories(includeAllEntities: true);
        //});

        Configure<AbpDbContextOptions>(options =>
        {
                /* The main point to change your DBMS.
                 * See also Test_ModernMonolithicArchitectureMigrationsDbContextFactory for EF Core tooling. */
            options.UseSqlServer();
        });

    }
}
