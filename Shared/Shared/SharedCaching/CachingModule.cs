 using Volo.Abp.AspNetCore.Serilog;
using Volo.Abp.Autofac;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Data;  
using Volo.Abp.Localization;
using Volo.Abp.Modularity; 
using Volo.Abp.Swashbuckle;


namespace SharedCaching
{
    [DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpDataModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(AbpAspNetCoreSerilogModule),
    typeof(AbpSwashbuckleModule)
    )]
    public class CachingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
             
        }
         

    }
}