using ProductCatalog.DTOs;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ProductCatalog.IServices;

public interface IProductAppService : IApplicationService
{
    Task<ProductDto> CreateAsync(CreateUpdateProductDto input);
    Task<ProductDto> GetAsync(Guid id);
    Task<ListResultDto<ProductDto>> GetAllAsync();
    Task<ProductDto> UpdateAsync(Guid id, CreateUpdateProductDto input);
    Task DeleteAsync(Guid id);

}
