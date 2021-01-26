using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> ProductsList { get; set; }
        public string CurrentCategory { get; set; }
    }
}
