using ShoppingCart.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ShoppingCart;

public abstract class ShoppingCartController : AbpControllerBase
{
    protected ShoppingCartController()
    {
        LocalizationResource = typeof(ShoppingCartResource);
    }
}
