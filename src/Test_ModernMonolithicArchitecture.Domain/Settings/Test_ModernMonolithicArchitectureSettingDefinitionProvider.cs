using Volo.Abp.Settings;

namespace Test_ModernMonolithicArchitecture.Settings;

public class Test_ModernMonolithicArchitectureSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(Test_ModernMonolithicArchitectureSettings.MySetting1));
    }
}
