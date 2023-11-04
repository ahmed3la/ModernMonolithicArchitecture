using ShoppingCart.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace ShoppingCart.IService
{
    internal interface IShoppingCartAppService
    {
        Task<ShoppingCartItemDto> AddItemAsync(Guid cartId, Guid productId, int quantity);

        Task<ListResultDto<ShoppingCartItemDto>> GetItemsAsync(Guid cartId);

        Task UpdateItemAsync(Guid cartItemId, int newQuantity);

        Task RemoveItemAsync(Guid cartItemId);
    }
}
