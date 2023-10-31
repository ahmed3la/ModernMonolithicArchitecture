using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Test_ModernMonolithicArchitecture.Data;
using Volo.Abp.DependencyInjection;

namespace Test_ModernMonolithicArchitecture.EntityFrameworkCore;

public class EntityFrameworkCoreTest_ModernMonolithicArchitectureDbSchemaMigrator
    : ITest_ModernMonolithicArchitectureDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTest_ModernMonolithicArchitectureDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the Test_ModernMonolithicArchitectureDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Test_ModernMonolithicArchitectureDbContext>()
            .Database
            .MigrateAsync();
    }
}
