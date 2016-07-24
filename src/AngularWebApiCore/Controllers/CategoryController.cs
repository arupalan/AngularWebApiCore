using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AngularWebApiCore.Models;
using AngularWebApiCore.Repository;
using Microsoft.AspNetCore.Mvc;
using AngularWebApiCore._Code;

namespace AngularWebApiCore.Controllers
{
    [ApiExceptionFilter]
    public class CategoryController : Controller
    {
        private readonly CategoryRepository _repository;


        public CategoryController()
        {
            _repository = new CategoryRepository();
        }

        [HttpGet]
        [Route("api/helloworld")]
        public object HelloWorld(string name = null)
        {
            //return "Hello " + name + ". Time is: " + DateTime.Now;
            if (string.IsNullOrEmpty(name))
                name = "Arup Banerjee";

            return new { helloMessage = "Hello!  " + name + ". Time is: " + DateTime.Now };
        }

        // GET api/Category
        [HttpGet]
        [Route("api/category")]
        public  async Task<IEnumerable<Category>> Get()
        {
            return await Task.FromResult(_repository.GetCategories());
        }

        // GET api/Category/GetSubCategories/5
        [HttpGet("api/Category/GetSubCategories/{id:int}")]
        public async Task<IEnumerable<Category>> GetSubCategories(int id)
        {
            return await Task.FromResult(_repository.GetSubCategories(id));
        }
    }
}
