using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products.DTO
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
