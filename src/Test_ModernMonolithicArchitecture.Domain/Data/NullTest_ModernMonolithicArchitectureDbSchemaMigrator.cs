using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Test_ModernMonolithicArchitecture.Data;

/* This is used if database provider does't define
 * ITest_ModernMonolithicArchitectureDbSchemaMigrator implementation.
 */
public class NullTest_ModernMonolithicArchitectureDbSchemaMigrator : ITest_ModernMonolithicArchitectureDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
