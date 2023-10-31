using Test_ModernMonolithicArchitecture.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Test_ModernMonolithicArchitecture.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Test_ModernMonolithicArchitectureEntityFrameworkCoreModule),
    typeof(Test_ModernMonolithicArchitectureApplicationContractsModule)
    )]
public class Test_ModernMonolithicArchitectureDbMigratorModule : AbpModule
{
}
