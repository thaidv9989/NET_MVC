using CRUD_D1.Models;
using CRUD_D1.Repositories;

namespace CRUD_D1.Service.Implement
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void AddCategory(Category Category)
        {
            _categoryRepository.AddCategory(Category);
        }

        public void DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
        }

        public Category? GetCategory(int id)
        {
            return _categoryRepository.GetCategory(id);
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categoryRepository.GetCategories();
        }

        public void UpdateCategory(Category Category)
        {
            _categoryRepository.UpdateCategory(Category);
        }
    }
}
