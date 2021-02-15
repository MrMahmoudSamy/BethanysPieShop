using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating  (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit Pie", Description = "All fruit pie" },
               new Category { CategoryId = 2, CategoryName = "Cheese cakes", Description = "Chees" },
               new Category { CategoryId = 3, CategoryName = "Coffee", Description = "Coffee beans makes drinks" },
               new Category { CategoryId = 4, CategoryName = "Fruit Juice", Description = "All fruit juice" });

            modelBuilder.Entity<Product>().HasData(new Product { CategoryId = 1, ProductId = 1, Name = "Strawberry Pie", Price = 15.95M, ImageThumbnailUrl = "~/images/59b13b33-a1fd-47b3-a376-f735af81c40a.jpg" },
            new Product { CategoryId = 1, ProductId = 2, Name = "Appel Pie", Price = 15.95M, ImageThumbnailUrl = "~/images/ApplePie.jpg" },
            new Product { CategoryId = 2, ProductId = 3, Name = "Cheese cake", Price = 15.95M, ImageThumbnailUrl = "~/images/CheeseCacke.jpg" },
            new Product { CategoryId = 3, ProductId = 4, Name = "Turkey coffe", Price = 15.95M, ImageThumbnailUrl = "~/images/turkish-coffee.jpg" },
            new Product { CategoryId = 4, ProductId = 5, Name = "Strawberry Smoothy", Price = 15.95M, ImageThumbnailUrl = "~/images/strawberrysmoothie.jpg" });

        }
    }
}
