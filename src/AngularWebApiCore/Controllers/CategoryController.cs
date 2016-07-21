using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularWebApiCore.Models;
using AngularWebApiCore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AngularWebApiCore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryRepository _repository = new CategoryRepository();


        // GET api/Category
        [HttpGet]
        public  async Task<IEnumerable<Category>> Get()
        {
            return await Task.FromResult(_repository.GetCategories());
        }

        // GET api/Category/GetSubCategories/5
        [HttpGet("GetSubCategories/{id}")]
        public async Task<IEnumerable<Category>> GetSubCategories(int id)
        {
            return await Task.FromResult(_repository.GetSubCategories(id));
        }
    }
}
