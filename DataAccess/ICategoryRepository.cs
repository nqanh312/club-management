using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        Category GetCategoryById(int catId);
        void InsertCategory(Category category);
        void DeleteCategory(int catId);
        void UpdateCategory(Category category);

    }
}
