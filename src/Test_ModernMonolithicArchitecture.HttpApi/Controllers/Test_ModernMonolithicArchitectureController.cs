using Test_ModernMonolithicArchitecture.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Test_ModernMonolithicArchitecture.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Test_ModernMonolithicArchitectureController : AbpControllerBase
{
    protected Test_ModernMonolithicArchitectureController()
    {
        LocalizationResource = typeof(Test_ModernMonolithicArchitectureResource);
    }
}
