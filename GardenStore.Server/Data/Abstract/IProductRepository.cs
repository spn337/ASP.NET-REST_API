using GardenStore.Server.Models;
using System.Collections.Generic;

namespace GardenStore.Server.Data.Abstract
{
    public interface IProductRepository
    {
        bool SaveChanges();
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void CreateProduct(Product product);
    }
}
