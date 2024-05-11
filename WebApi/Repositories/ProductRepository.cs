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

        public Task<List<Product>> GetAllAsync()
        {
            return _context.Products.AsNoTracking().ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.AsNoTracking().SingleOrDefaultAsync(p => p.Id == id);
        }
    }
}
