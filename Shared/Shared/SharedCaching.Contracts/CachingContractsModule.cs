using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace SharedCaching.Contracts
{
    [DependsOn(
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]


    public class CachingContractsModule : AbpModule
    {

    }
}