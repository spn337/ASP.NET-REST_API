using GardenStore.Server.Data.Abstract;
using GardenStore.Server.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GardenStore.Server.Controllers
{
    //api/products 
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repository;
        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }

        //GET api/product/
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var products = _repository.GetAllProducts();

            return Ok(products);
        }

        //GET api/product/1
        [HttpGet("{id}")]
        public ActionResult<Product> GetProductsById(int id)
        {
            var product = _repository.GetProductById(id);

            return Ok(product);
        }
    }
}
