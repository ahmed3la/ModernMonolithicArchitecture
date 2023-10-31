using Volo.Abp.Modularity;

namespace Test_ModernMonolithicArchitecture;

[DependsOn(
    typeof(Test_ModernMonolithicArchitectureApplicationModule),
    typeof(Test_ModernMonolithicArchitectureDomainTestModule)
    )]
public class Test_ModernMonolithicArchitectureApplicationTestModule : AbpModule
{

}
