using CRUD_D1.Data;
using CRUD_D1.Models;

namespace CRUD_D1.Repositories.Implement
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationContext _dbContext;

        public CategoryRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            var rs = _dbContext.Categories.FirstOrDefault(c => c.Category_Id == id);
            if(rs == null)
            {
                throw new Exception("Not found item");
            }
            _dbContext.Categories.Remove(rs);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _dbContext.Categories.ToList();
        }

        public Category? GetCategory(int id)
        {
            return _dbContext.Categories.FirstOrDefault(c => c.Category_Id == id);
        }

        public void UpdateCategory(Category category)
        {
            var rs = _dbContext.Categories.FirstOrDefault(c => c.Category_Id == category.Category_Id);
            if (rs == null)
            {
                throw new Exception("Not found this product with id: " + category.Category_Id);
            }
            rs.Category_Id = category.Category_Id;
            rs.Category_Name= category.Category_Name;
            _dbContext.Categories.Update(rs);
            _dbContext.SaveChanges();
        }
    }
}
