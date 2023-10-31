using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Test_ModernMonolithicArchitecture;

[Dependency(ReplaceServices = true)]
public class Test_ModernMonolithicArchitectureBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Test_ModernMonolithicArchitecture";
}
