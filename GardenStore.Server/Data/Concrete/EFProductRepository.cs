using GardenStore.Server.Data.Abstract;
using GardenStore.Server.Models;
using System.Collections.Generic;
using System.Linq;

namespace GardenStore.Server.Data.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private readonly EFDbContext _context;

        public EFProductRepository(EFDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }
        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
