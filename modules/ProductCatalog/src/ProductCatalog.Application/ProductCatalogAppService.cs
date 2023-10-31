using ProductCatalog.Localization;
using Volo.Abp.Application.Services;

namespace ProductCatalog;

public abstract class ProductCatalogAppService : ApplicationService
{
    protected ProductCatalogAppService()
    {
        LocalizationResource = typeof(ProductCatalogResource);
        ObjectMapperContext = typeof(ProductCatalogApplicationModule);
    }
}
