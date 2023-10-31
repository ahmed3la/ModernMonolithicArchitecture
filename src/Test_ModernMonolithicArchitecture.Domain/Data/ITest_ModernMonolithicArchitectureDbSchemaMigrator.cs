using System.Threading.Tasks;

namespace Test_ModernMonolithicArchitecture.Data;

public interface ITest_ModernMonolithicArchitectureDbSchemaMigrator
{
    Task MigrateAsync();
}
