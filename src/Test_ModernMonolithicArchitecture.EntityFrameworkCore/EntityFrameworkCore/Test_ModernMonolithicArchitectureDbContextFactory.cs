using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Test_ModernMonolithicArchitecture.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class Test_ModernMonolithicArchitectureDbContextFactory : IDesignTimeDbContextFactory<Test_ModernMonolithicArchitectureDbContext>
{
    public Test_ModernMonolithicArchitectureDbContext CreateDbContext(string[] args)
    {
        Test_ModernMonolithicArchitectureEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<Test_ModernMonolithicArchitectureDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new Test_ModernMonolithicArchitectureDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Test_ModernMonolithicArchitecture.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
