using CRUD_D1.Models;

namespace CRUD_D1.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        Category? GetCategory(int id);
        void AddCategory(Category category);    
        void UpdateCategory(Category category); 
        void DeleteCategory(int id);

    }
}
