using ShoppingCart.CartEntities;
using ShoppingCart.DTOs;
using ShoppingCart.IAppService;
using ShoppingCart.IRepository;
using System;
using System.Threading.Tasks;
using Volo.Abp.Guids;

namespace ShoppingCart.Services;

public class ShoppingCartAppService : BaseShoppingCartAppService, ICartAppService
{
    private readonly IShoppingCartRepository _shoppingCartRepository;
    private readonly IShoppingCartItemRepository _shoppingCartItemRepository;
    private readonly IGuidGenerator guidGenerator;

    public ShoppingCartAppService(
        IShoppingCartRepository shoppingCartRepository,
        IShoppingCartItemRepository shoppingCartItemRepository, IGuidGenerator guidGenerator)
    {
        _shoppingCartRepository = shoppingCartRepository;
        _shoppingCartItemRepository = shoppingCartItemRepository;
        this.guidGenerator = guidGenerator;
    }

  

    public async Task<CartDto> AddItemAsync(Guid cartId, Guid productId, int quantity, decimal price)
    {

        // Implement logic to add an item to the shopping cart.
        var cart = await _shoppingCartRepository.GetAsync(cartId);

        if (cart != null)
        {
            cart.AddItem(guidGenerator.Create(), cartId, productId, quantity, price);
            await _shoppingCartRepository.UpdateAsync(cart);
        }

        return ObjectMapper.Map<Cart, CartDto>(cart);
    }

    public async Task<CartDto> GetAsync(Guid cartId)
    {
        var cart = await _shoppingCartRepository.GetAsync(cartId); 


        return ObjectMapper.Map<Cart, CartDto>(cart); 
    }
}
