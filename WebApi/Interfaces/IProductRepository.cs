using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Data;

namespace WebApi.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
    }
}
