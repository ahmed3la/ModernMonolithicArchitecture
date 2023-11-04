using ShoppingCart.Localization;
using Volo.Abp.Application.Services;

namespace ShoppingCart;

public abstract class BaseShoppingCartAppService : ApplicationService
{
    protected BaseShoppingCartAppService()
    {
        LocalizationResource = typeof(ShoppingCartResource);
        ObjectMapperContext = typeof(ShoppingCartApplicationModule);
    }
}
