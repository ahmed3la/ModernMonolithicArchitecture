using System;
using System.Collections.Generic;
using System.Text;
using Test_ModernMonolithicArchitecture.Localization;
using Volo.Abp.Application.Services;

namespace Test_ModernMonolithicArchitecture;

/* Inherit your application services from this class.
 */
public abstract class Test_ModernMonolithicArchitectureAppService : ApplicationService
{
    protected Test_ModernMonolithicArchitectureAppService()
    {
        LocalizationResource = typeof(Test_ModernMonolithicArchitectureResource);
    }
}
