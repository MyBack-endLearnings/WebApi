using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Data;
using WebApi.Interfaces;

namespace WebApi.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public Task<List<Product>> GetAllAsync()
        {
            return _context.Products.AsNoTracking().ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.AsNoTracking().SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            Product product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            Product dbProduct = await _context.Products.FindAsync(product.Id);
            _context.Entry(dbProduct).CurrentValues.SetValues(product);
            await _context.SaveChangesAsync();
        }
    }
}
