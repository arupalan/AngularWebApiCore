using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularWebApiCore.Models;
using AngularWebApiCore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AngularWebApiCore.Controllers
{
    [Route("api/[controller]")]
    public class ProductController: Controller
    {
        private readonly ProductRepository _repository = new ProductRepository();

        // GET api/Product
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _repository.GetProductList();
        }

        // GET api/Product/GetProductListBySubCategory/3
        [HttpGet("GetProductListBySubCategory/{id}")]
        public async Task<IEnumerable<Product>> GetProductListBySubCategory(int id)
        {
            return await Task.FromResult(_repository.GetProductListBySubCategory(id));
        }

        [HttpPost]
        public async Task<Product> Edit(Product product)
        {
            return await Task.FromResult(_repository.Edit(product));
        }
    }
}
