using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BethanysPieShop.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> Allproducts => new List<Product> {
            new Product { CategoryId = 1, ProductId = 1,Name="Strawberry Pie" ,Price=15.95M },
            new Product { CategoryId = 1, ProductId = 2,Name="Appel Pie" ,Price=15.95M },
            new Product { CategoryId = 2, ProductId = 3,Name="Cheese cake" ,Price=15.95M },
            new Product { CategoryId = 3, ProductId = 4,Name="Turkey coffe" ,Price=15.95M },
            new Product { CategoryId = 4, ProductId = 5,Name="Strawberry Smoothy" ,Price=15.95M }
            };

        public IEnumerable<Product> AllproductOftheWeek => throw new NotImplementedException();

        public Product GetProductById(int prodId)
        {
            return Allproducts.FirstOrDefault(p => p.ProductId == prodId);
        }
    }
}
