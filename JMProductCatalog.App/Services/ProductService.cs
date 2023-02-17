using AutoMapper;
using JMProductCatalog.App.DTOs;
using JMProductCatalog.App.Interfaces;
using JMProductCatalog.Domain.Entities;
using JMProductCatalog.Domain.Interfaces;

namespace JMProductCatalog.App.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _repository;

        public ProductService(IMapper mapper, IProductRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task AddAsync(ProductDTO product)
        {
            Product productEntity = _mapper.Map<Product>(product);
            await _repository.CreateAsync(productEntity);
        }

        public async Task<ProductDTO> GetProductByIdAsync(Guid? ProductId)
        {
            Product productEntity = await _repository.GetByIdAsync(ProductId);
            return _mapper.Map<ProductDTO>(productEntity);
        }

        public async Task<ProductDTO> GetProductCategoryAsync(Guid? ProductCategoryId)
        {
            Product productEntity = await _repository.GetProductCategoryAsync(ProductCategoryId);
            return _mapper.Map<ProductDTO>(productEntity);
        }

        public async Task<IEnumerable<ProductDTO>> GetProductsAsync()
        {
            IEnumerable<Product> products = await _repository.GetProductsAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public async Task RemoveAsync(ProductDTO product)
        {
            Product productEntity = _mapper.Map<Product>(product);
            await _repository.RemoveAsync(productEntity);
        }

        public async Task UpdateAsync(ProductDTO product)
        {
            Product productEntity = _mapper.Map<Product>(product);
            await _repository.UpdateAsync(productEntity);
        }
    }
}
