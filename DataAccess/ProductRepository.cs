using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(int productId) => ProductDAO.Instance.Remove(productId);


        public IEnumerable<Product> GetProduct() => ProductDAO.Instance.GetProductList();
      
        public Product GetProductByID(int productId) => ProductDAO.Instance.GetProductByID(productId);

        public void InsertProduct(Product product) => ProductDAO.Instance.AddNew(product);
        

        public void UpdateProduct(Product product) => ProductDAO.Instance.Update(product);
    }
}
