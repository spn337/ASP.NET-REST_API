using GardenStore.Server.Models;
using System.Collections.Generic;

namespace GardenStore.Server.Data
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
