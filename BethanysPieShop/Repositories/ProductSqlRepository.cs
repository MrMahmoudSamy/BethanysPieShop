using BethanysPieShop.Data;
using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Repositories
{
    public class ProductSqlRepository : IProductRepository
    {
        private AppDbContext _context;

        public ProductSqlRepository(AppDbContext Context) 
        {
            _context = Context;
        }
        public IEnumerable<Product> Allproducts
        {
            get
            {
                return _context.Products.Include(c=>c.Category).ToList();
            }
        }
        public IEnumerable<Product> AllproductOftheWeek
        {
            get
            {
                return _context.Products.Include(c => c.Category).Where(p=>p.IsProductOftheWeek);
            }
        }

        public Product GetProductById(int prodId)
        {
            return _context.Products.SingleOrDefault(p=>p.ProductId==prodId);
        }
    }
}
