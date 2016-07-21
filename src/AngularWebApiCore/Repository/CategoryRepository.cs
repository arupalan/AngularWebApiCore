using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularWebApiCore.Models;

namespace AngularWebApiCore.Repository
{
    public class CategoryRepository
    {
        public IEnumerable<Category> GetCategories()
        {
            return MockData.Categories;
        }

        public IEnumerable<Category> GetSubCategories(int id)
        {
            return MockData.SubCategories.Where(x => x.ParentCategoryId == id).Select(subCategory => new Category() { Id = subCategory.Id, Name = subCategory.Name });
        }
    }
}
