using BethanysPieShop.Data;
using BethanysPieShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShop.Repositories
{
    public class CategorySqlRepository:ICategoryRepository
    {
        private AppDbContext _context;

        public CategorySqlRepository(AppDbContext Context)
        {
            _context = Context;
        }

        public IEnumerable<Category> Categories => _context.Categories.ToList();
    }
}
