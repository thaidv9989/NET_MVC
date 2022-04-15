using CRUD_D1.Models;

namespace CRUD_D1.Service
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories();
        Category? GetCategory(int id);
        void AddCategory(Category Category);
        void UpdateCategory(Category Category);
        void DeleteCategory(int id);
    }
}
