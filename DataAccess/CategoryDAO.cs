using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDAO
    {
        private static CategoryDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                }
                return instance;
            }
        }

        public IEnumerable<Category> GetCategoryList()
        {
            var categories = new List<Category>();
            try
            {
                using var context = new myestoreContext();
                categories = context.Categories.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return categories;
        }

        public Category GetCategoryByID(int categoryId)
        {
            Category categories = null;
            try
            {
                using var context = new myestoreContext();
                categories = context.Categories.SingleOrDefault(c => c.CategoryId == categoryId);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return categories;
        }

        public void AddNew(Category category)
        {
            try
            {
                Category _categories = GetCategoryByID(category.CategoryId);
                if (_categories == null)
                {
                    using var context = new myestoreContext();
                    context.Categories.Add(category);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Category is already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Update(Category category)
        {
            try
            {

                Category _categories = GetCategoryByID(category.CategoryId);
                if (_categories != null)
                {
                    using var context = new myestoreContext();
                    context.Categories.Update(category);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Category does not already exist");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Remove(int categoryId)
        {
            try
            {

                Category category = GetCategoryByID(categoryId);
                if (category != null)
                {
                    using var context = new myestoreContext();
                    context.Categories.Remove(category);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Category does not already exist");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
