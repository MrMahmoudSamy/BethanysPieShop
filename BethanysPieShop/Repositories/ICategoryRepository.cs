using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Repositories
{
   public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
