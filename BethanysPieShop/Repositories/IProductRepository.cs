using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> Allproducts { get; }
        IEnumerable<Product> AllproductOftheWeek { get; }
        Product GetProductById(int prodId);
    }
}
