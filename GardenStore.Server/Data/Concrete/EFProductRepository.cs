using GardenStore.Server.Data.Abstract;
using GardenStore.Server.Models;
using System.Collections.Generic;
using System.Linq;
using System;
 
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
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
        public void CreateProduct(Product product)
        {
            if(product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            _context.Products.Add(product);
        }   
        public void UpdateProduct(Product product)
        {
            //Nothing
        }

        public void DeleteProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            _context.Products.Remove(product);
        }
    }
}
