using Microsoft.EntityFrameworkCore;
using System;

namespace WebApi.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                new Category() { Id = 1, Name = "Category 1" },
                new Category() { Id = 2, Name = "Category 2" },
                new Category() { Id = 3, Name = "Category 3" },
                new Category() { Id = 4, Name = "Category 4" },
                new Category() { Id = 5, Name = "Category 5" }
            });

            modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new Product() { Id = 1, Name = "Product 1", Price = 100, Stock = 10, ImagePath = "product1.jpg", CreatedDate = DateTime.Now, CategoryId = 1},
                new Product() { Id = 2, Name = "Product 2", Price = 200, Stock = 20, ImagePath = "product2.jpg", CreatedDate = DateTime.Now, CategoryId = 2 },
                new Product() { Id = 3, Name = "Product 3", Price = 300, Stock = 30, ImagePath = "product3.jpg", CreatedDate = DateTime.Now, CategoryId = 3 },
                new Product() { Id = 4, Name = "Product 4", Price = 400, Stock = 40, ImagePath = "product4.jpg", CreatedDate = DateTime.Now , CategoryId = 4},
                new Product() { Id = 5, Name = "Product 5", Price = 500, Stock = 50, ImagePath = "product5.jpg", CreatedDate = DateTime.Now , CategoryId = 5},
                new Product() { Id = 6, Name = "Product 6", Price = 600, Stock = 60, ImagePath = "product6.jpg", CreatedDate = DateTime.Now , CategoryId = 1},
                new Product() { Id = 7, Name = "Product 7", Price = 700, Stock = 70, ImagePath = "product7.jpg", CreatedDate = DateTime.Now , CategoryId = 2},
                new Product() { Id = 8, Name = "Product 8", Price = 800, Stock = 80, ImagePath = "product8.jpg", CreatedDate = DateTime.Now , CategoryId = 3},
                new Product() { Id = 9, Name = "Product 9", Price = 900, Stock = 90, ImagePath = "product9.jpg", CreatedDate = DateTime.Now , CategoryId = 4},
                new Product() { Id = 10, Name = "Product 10", Price = 1000, Stock = 100, ImagePath = "product10.jpg", CreatedDate = DateTime.Now , CategoryId = 5},
                new Product() { Id = 11, Name = "Product 11", Price = 1100, Stock = 110, ImagePath = "product11.jpg", CreatedDate = DateTime.Now , CategoryId = 1},
                new Product() { Id = 12, Name = "Product 12", Price = 1200, Stock = 120, ImagePath = "product12.jpg", CreatedDate = DateTime.Now , CategoryId = 2},
                new Product() { Id = 13, Name = "Product 13", Price = 1300, Stock = 130, ImagePath = "product13.jpg", CreatedDate = DateTime.Now, CategoryId = 3 },
                new Product() { Id = 14, Name = "Product 14", Price = 1400, Stock = 140, ImagePath = "product14.jpg", CreatedDate = DateTime.Now, CategoryId = 4 },
                new Product() { Id = 15, Name = "Product 15", Price = 1500, Stock = 150, ImagePath = "product15.jpg", CreatedDate = DateTime.Now, CategoryId = 5 }
            });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
