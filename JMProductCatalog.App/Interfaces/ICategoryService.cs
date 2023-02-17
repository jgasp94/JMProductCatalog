using JMProductCatalog.App.DTOs;

namespace JMProductCatalog.App.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategoriesAsync();
        Task<CategoryDTO>  GetCategoryByIdAsync(Guid? CategoryId);
        Task AddAsync(CategoryDTO category);
        Task UpdateAsync(CategoryDTO category);
        Task DeleteAsync(CategoryDTO category);
    }
}
