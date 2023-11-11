using ProductCatalog.IServices;
using ShoppingCart.DTOs;
using ShoppingCart.IAppService;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;

namespace Test_ModernMonolithicArchitecture.ACLServices
{
    public class AclShoppingCart : Test_ModernMonolithicArchitectureAppService
    {

        private readonly ICartAppService cartAppService;
        private readonly IProductAppService productAppService;

        public AclShoppingCart(
        ICartAppService cartAppService,
        IProductAppService productAppService)
        {
            this.cartAppService = cartAppService;
            this.productAppService = productAppService;
        }

        public async Task<CartDto> AddItemAsync(Guid ownerId, Guid cartId, Guid productId, int quantity)
        {
            var product = await productAppService.GetAsync(productId)
                ?? throw new UserFriendlyException("The product not exist");

            var cart = await cartAppService.AddItemAsync(ownerId, cartId, productId, quantity, product.Price)
                ?? throw new UserFriendlyException("The product was not added");
            //
            cart.ShoppingCartItems.Last().ProductName = product.Name;
            //try exception
            await productAppService.DeleteAsync(productId);
            
            return cart;
        }

    }
}
