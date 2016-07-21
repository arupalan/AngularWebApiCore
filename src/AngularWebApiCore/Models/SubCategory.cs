using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWebApiCore.Models
{
    public class SubCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ParentCategoryId { get; set; }
    }
}
