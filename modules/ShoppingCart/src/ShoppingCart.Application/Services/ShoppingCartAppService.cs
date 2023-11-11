using ShoppingCart.CartEntities;
using ShoppingCart.DTOs;
using ShoppingCart.IAppService;
using ShoppingCart.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
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
        IShoppingCartItemRepository shoppingCartItemRepository, 
        IGuidGenerator guidGenerator)
    {
        _shoppingCartRepository = shoppingCartRepository;
        _shoppingCartItemRepository = shoppingCartItemRepository;
        this.guidGenerator = guidGenerator;
    }



    public async Task<CartDto> AddItemAsync(Guid ownerId, Guid cartId, Guid productId, int quantity, decimal price)
    {
        bool isNewCart = false;
        // Implement logic to add an item to the shopping cart.
        var cart = await _shoppingCartRepository.GetAsync(cartId);

        if (cart == null)
        {
            cart = new Cart(cartId, ownerId);
            isNewCart = true;
        }

        cart.AddItem(guidGenerator.Create(), cart.Id, productId, quantity, price);

        if(isNewCart)
            await _shoppingCartRepository.InsertAsync(cart);
        else
            await _shoppingCartRepository.UpdateAsync(cart);

        return new CartDto
        {
            Id = cart.Id,
            OwnerId = cart.OwnerId,
            ShoppingCartItems = cart.Items.Select(x => new ShoppingCartItemDto
            {
                Id = x.Id,
                ProductId = x.ProductId,
                Quantity = x.Quantity,
                Price = x.Price
            }).ToList(),
        };
        //return ObjectMapper.Map<Cart, CartDto>(cart);
    }

    public async Task<CartDto> GetAsync(Guid cartId)
    {
        var cart = await _shoppingCartRepository.GetAsync(cartId);

        return new CartDto
        {
            Id = cart.Id,
            OwnerId = cart.OwnerId
        };
    }
}
