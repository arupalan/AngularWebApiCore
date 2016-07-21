using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularWebApiCore.Models;

namespace AngularWebApiCore.Repository
{
    public class ProductRepository
    {
        public IEnumerable<Product> GetProductListBySubCategory(int id)
        {
            return MockData.Products.Where(x => x.SubCategoryId == id);
        }

        public Product Edit(Product product)
        {
            MockData.Products.RemoveAll(x => x.ProductKey == product.ProductKey);
            MockData.Products.Add(product);

            return product;
        }

        public IEnumerable<Product> GetProductList()
        {
            return MockData.Products;
        }

        public IEnumerable<Product> GetProductByKey(int productKey)
        {
            return MockData.Products.Where(x => x.ProductKey == productKey);
        }
    }
}
