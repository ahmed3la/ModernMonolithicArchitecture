using ProductCatalog.IServices;
using SharedCaching.ICachingProducts;
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
        private readonly ICachingProduct cachingProduct;

        public AclShoppingCart(
        ICartAppService cartAppService,
        IProductAppService productAppService,
        ICachingProduct cachingProduct)
        {
            this.cartAppService = cartAppService;
            this.productAppService = productAppService;
            this.cachingProduct = cachingProduct;
        }

        public async Task<CartDto> AddItemAsync(Guid ownerId, Guid cartId, Guid productId, int quantity)
        {
            var product = await cachingProduct.GetAsync(productId); 

            //var product = await productAppService.GetAsync(productId)
            //    ?? throw new UserFriendlyException("The product not exist");

            var cart = await cartAppService.AddItemAsync(ownerId, cartId, productId, quantity, product.Price)
                ?? throw new UserFriendlyException("The product was not added");
            //
            cart.ShoppingCartItems.Last().ProductName = product.Name;
            //try exception
            //await productAppService.DeleteAsync(productId);
            
            return cart;
        }

    }
}
