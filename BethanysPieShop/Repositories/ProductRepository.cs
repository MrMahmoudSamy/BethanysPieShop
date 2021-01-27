using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BethanysPieShop.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ICategoryRepository categoryRepo = new CategoryRepository();
        public IEnumerable<Product> Allproducts => new List<Product> {
            new Product { CategoryId = 1, ProductId = 1,Name="Strawberry Pie" ,Price=15.95M ,ImageThumbnailUrl="~/images/59b13b33-a1fd-47b3-a376-f735af81c40a.jpg"},
            new Product { CategoryId = 1, ProductId = 2,Name="Appel Pie" ,Price=15.95M,ImageThumbnailUrl="~/images/ApplePie.jpg"},
            new Product { CategoryId = 2, ProductId = 3,Name="Cheese cake" ,Price=15.95M ,ImageThumbnailUrl="~/images/CheeseCacke.jpg"},
            new Product { CategoryId = 3, ProductId = 4,Name="Turkey coffe" ,Price=15.95M ,ImageThumbnailUrl="~/images/turkish-coffee.jpg"},
            new Product { CategoryId = 4, ProductId = 5,Name="Strawberry Smoothy" ,Price=15.95M ,ImageThumbnailUrl="~/images/strawberrysmoothie.jpg"}
            };

        public IEnumerable<Product> AllproductOftheWeek => throw new NotImplementedException();

        public Product GetProductById(int prodId)
        {
            return Allproducts.FirstOrDefault(p => p.ProductId == prodId);
        }
    }
}
