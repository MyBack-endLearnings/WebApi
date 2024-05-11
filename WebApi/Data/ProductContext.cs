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
            modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new Product() { Id = 1, Name = "Product 1", Price = 100, Stock = 10, ImagePath = "product1.jpg", CreatedDate = DateTime.Now },
                new Product() { Id = 2, Name = "Product 2", Price = 200, Stock = 20, ImagePath = "product2.jpg", CreatedDate = DateTime.Now },
                new Product() { Id = 3, Name = "Product 3", Price = 300, Stock = 30, ImagePath = "product3.jpg", CreatedDate = DateTime.Now },
                new Product() { Id = 4, Name = "Product 4", Price = 400, Stock = 40, ImagePath = "product4.jpg", CreatedDate = DateTime.Now },
                new Product() { Id = 5, Name = "Product 5", Price = 500, Stock = 50, ImagePath = "product5.jpg", CreatedDate = DateTime.Now }
           });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
}
