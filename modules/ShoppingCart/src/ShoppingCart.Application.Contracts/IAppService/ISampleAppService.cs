using ShoppingCart.DTOs; 
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ShoppingCart.IAppService;

public interface ICartAppService : IApplicationService
{
    Task<CartDto> GetAsync(Guid cartId);

    Task<CartDto> AddItemAsync(Guid ownerId, Guid cartId, Guid productId, int quantity, decimal price);



}
