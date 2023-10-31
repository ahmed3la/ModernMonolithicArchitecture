using ProductCatalog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductCatalog;

public abstract class ProductCatalogController : AbpControllerBase
{
    protected ProductCatalogController()
    {
        LocalizationResource = typeof(ProductCatalogResource);
    }
}
