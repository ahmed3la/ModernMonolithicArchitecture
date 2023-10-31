using ProductCatalog.DTOs;
using ProductCatalog.IRepository;
using ProductCatalog.IServices;
using ProductCatalog.ProductEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace ProductCatalog.Services
{
    public class ProductAppService : ProductCatalogAppService, IProductAppService
    {
        private readonly IProductRepository _productRepository;

        public ProductAppService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        //[Area(ProductCatalogRemoteServiceConsts.ModuleName)]
        //[RemoteService(Name = ProductCatalogRemoteServiceConsts.RemoteServiceName)]
        //[Route("api/ProductCatalog/sample")]
        public async Task<ProductDto> CreateAsync(CreateUpdateProductDto input)
        {
            var product = new Product(
                Guid.NewGuid(), // Simplified ID generation
                input.Name,
                input.Description,
                input.Price
            );

            await _productRepository.InsertAsync(product);
            return ObjectMapper.Map<Product, ProductDto>(product);
        }

        public async Task<ProductDto> GetAsync(Guid id)
        {
            var product = await _productRepository.GetAsync(id);
            return ObjectMapper.Map<Product, ProductDto>(product);
        }

        public async Task<ListResultDto<ProductDto>> GetAllAsync()
        {
            var products = await _productRepository.GetListAsync();
            return new ListResultDto<ProductDto>(
                ObjectMapper.Map<List<Product>, List<ProductDto>>(products)
            );
        }

        public async Task<ProductDto> UpdateAsync(Guid id, CreateUpdateProductDto input)
        {
            var product = await _productRepository.GetAsync(id);
            product.Name = input.Name;
            product.Description = input.Description;
            product.Price = input.Price;
            return ObjectMapper.Map<Product, ProductDto>(product);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _productRepository.DeleteAsync(id);
        }
    }
}
