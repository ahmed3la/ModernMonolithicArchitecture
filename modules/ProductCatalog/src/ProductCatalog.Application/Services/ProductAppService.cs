using ProductCatalog.DTOs;
using ProductCatalog.IRepository;
using ProductCatalog.IServices;
using ProductCatalog.ProductEntities;
using SharedCaching.Contracts.CacheDTOs;
using SharedCaching.ICachingProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Volo.Abp.Application.Dtos;
using Volo.Abp.EventBus.Local;
using Volo.Abp.Guids;
using Volo.Abp.ObjectMapping;

namespace ProductCatalog.Services
{
    public class ProductAppService : ProductCatalogAppService, IProductAppService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICachingProduct cachingProduct;
        private readonly ILocalEventBus localEventBus;
        private readonly IGuidGenerator guidGenerator; 

        public ProductAppService(IProductRepository productRepository
            ,ICachingProduct cachingProduct,
            ILocalEventBus localEventBus,
            IGuidGenerator guidGenerator  
            )
        {
            
            _productRepository = productRepository;
            this.cachingProduct = cachingProduct;
            this.localEventBus = localEventBus;
            this.guidGenerator = guidGenerator; 
        }
        //[Area(ProductCatalogRemoteServiceConsts.ModuleName)]
        //[RemoteService(Name = ProductCatalogRemoteServiceConsts.RemoteServiceName)]
        //[Route("api/ProductCatalog/sample")]
        public async Task<ProductDto> CreateAsync(CreateUpdateProductDto input)
        {
            var id = guidGenerator.Create();
            var product = new Product(
                id, // Simplified ID generation
                input.Name,
                input.Description,
                input.Price
            );

            await _productRepository.InsertAsync(product);

            await localEventBus.PublishAsync(
                new ProductCacheEvent
                {
                    Id = id,
                    Name = input.Name,
                    Price = input.Price
                }
            );
            //return new ProductDto { Id = product.Id };
            try
            {
                return ObjectMapper.Map<Product, ProductDto>(product);
            }
            catch (Exception ex)
            {

                throw;
            } 
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
