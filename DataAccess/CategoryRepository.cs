using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryRepository : ICategoryRepository
    {
        public void DeleteCategory(int catId) => CategoryDAO.Instance.Remove(catId);

        public IEnumerable<Category> GetCategories() => CategoryDAO.Instance.GetCategoryList();

        public Category GetCategoryById(int catId) => CategoryDAO.Instance.GetCategoryByID(catId);
        public void InsertCategory(Category category) => CategoryDAO.Instance.AddNew(category);
        public void UpdateCategory(Category category) => CategoryDAO.Instance.Update(category);
      
    }
}
