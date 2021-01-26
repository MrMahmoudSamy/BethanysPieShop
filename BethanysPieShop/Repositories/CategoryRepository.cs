using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories =>
            new List<Category>
            {
               new  Category{CategoryId=1,CategoryName="Fruit Pie",Description="All fruit pie" },
               new  Category{CategoryId=2,CategoryName="Cheese cakes",Description="Chees" },
               new  Category{CategoryId=3,CategoryName="Coffees",Description="Coffees beans makes drinks" },
               new  Category{CategoryId=4,CategoryName="Fruit Juice",Description="All fruit juice" }

            };
    }
}
