using AutoMapper;
using GardenStore.Server.Data.Abstract;
using GardenStore.Server.DTOs;
using GardenStore.Server.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;

namespace GardenStore.Server.Controllers
{
    //api/products 
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductsController(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/product/
        [HttpGet]
        public ActionResult<IEnumerable<ProductReadDto>> GetProducts()
        {
            var productItems = _repository.GetAllProducts();

            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(productItems));
        }

        //GET api/product/{id}
        [HttpGet("{id}", Name = "GetProductById")]
        public ActionResult<ProductReadDto> GetProductById(int id)
        {
            var productItem = _repository.GetProductById(id);
            if (productItem == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ProductReadDto>(productItem));
        }

        //POST api/products
        [HttpPost]
        public ActionResult<ProductReadDto> CreateProduct(ProductCreateDto productCreateDto)
        {
            var productModel = _mapper.Map<Product>(productCreateDto);
            _repository.CreateProduct(productModel);
            _repository.SaveChanges();

            var productReadDto = _mapper.Map<ProductReadDto>(productModel);

            return CreatedAtRoute(
                routeName: nameof(GetProductById),
                routeValues: new { productReadDto.Id },
                value: productReadDto);
        }

        //PUT api/products/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, ProductUpdateDto productUpdateDto)
        {
            var productModel = _repository.GetProductById(id);
            if (productModel == null)
            {
                return NotFound();
            }

            _mapper.Map(productUpdateDto, productModel);
            _repository.UpdateProduct(productModel);
            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/products/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialProductUpdate(int id, JsonPatchDocument<ProductUpdateDto> patchDoc)
        {
            var productModel = _repository.GetProductById(id);
            if (productModel == null)
            {
                return NotFound();
            }

            var productToPatch = _mapper.Map<ProductUpdateDto>(productModel);
            patchDoc.ApplyTo(productToPatch, ModelState);

            if (!TryValidateModel(productToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(productToPatch, productModel);

            _repository.UpdateProduct(productModel);
            _repository.SaveChanges();
            return NoContent();
        }

        //DELETE api/products/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var productModel = _repository.GetProductById(id);
            if (productModel == null)
            {
                return NotFound();
            }
            _repository.DeleteProduct(productModel);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
