using JMProductCatalog.App.DTOs;

namespace JMProductCatalog.App.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetProductByIdAsync(Guid? ProductId);
        Task<ProductDTO> GetProductCategoryAsync(Guid? ProductCategoryId);
        Task UpdateAsync(ProductDTO product);
        Task AddAsync(ProductDTO product);
        Task RemoveAsync(ProductDTO product);
    }
}
