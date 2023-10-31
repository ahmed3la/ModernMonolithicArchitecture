using Test_ModernMonolithicArchitecture.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Test_ModernMonolithicArchitecture;

[DependsOn(
    typeof(Test_ModernMonolithicArchitectureEntityFrameworkCoreTestModule)
    )]
public class Test_ModernMonolithicArchitectureDomainTestModule : AbpModule
{

}
