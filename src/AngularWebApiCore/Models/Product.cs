using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWebApiCore.Models
{
    public class Product
    {
        public int ProductKey { get; set; }

        public string Name { get; set; }

        public short? StockLevel { get; set; }

        public int SubCategoryId { get; set; }
    }
}
