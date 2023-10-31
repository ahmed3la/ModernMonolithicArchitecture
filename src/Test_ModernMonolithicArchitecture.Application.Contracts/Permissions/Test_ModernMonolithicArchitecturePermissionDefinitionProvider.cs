using Test_ModernMonolithicArchitecture.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Test_ModernMonolithicArchitecture.Permissions;

public class Test_ModernMonolithicArchitecturePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Test_ModernMonolithicArchitecturePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Test_ModernMonolithicArchitecturePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Test_ModernMonolithicArchitectureResource>(name);
    }
}
