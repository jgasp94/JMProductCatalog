using AutoMapper;
using JMProductCatalog.App.DTOs;
using JMProductCatalog.App.Interfaces;
using JMProductCatalog.Domain.Entities;
using JMProductCatalog.Domain.Interfaces;

namespace JMProductCatalog.App.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task AddAsync(CategoryDTO category)
        {
            var categoryEntity = _mapper.Map<Category>(category);
            await _repository.CreateAsync(categoryEntity);
        }

        public async Task DeleteAsync(CategoryDTO category)
        {
            var categoryEnitity = _mapper.Map<Category>(category);
            await _repository.RemoveAsync(categoryEnitity);
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategoriesAsync()
        {
            IEnumerable<Category> categoriesEntity = await  _repository.GetCategoriesAsync();
            return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
        }

        public async Task<CategoryDTO> GetCategoryByIdAsync(Guid? CategoryId)
        {
            var catetoryEntity = await _repository.GetByIdAsync(CategoryId);
            return _mapper.Map<CategoryDTO>(catetoryEntity);
        }

        public async Task UpdateAsync(CategoryDTO category)
        {
            var categoryEntity = _mapper.Map<Category>(category);
            await _repository.UpdateAsync(categoryEntity);
        }
    }
}
