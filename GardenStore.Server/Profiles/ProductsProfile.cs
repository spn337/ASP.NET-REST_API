using AutoMapper;
using GardenStore.Server.DTOs;
using GardenStore.Server.Models;

namespace GardenStore.Server.Profiles
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            //Source -> Target
            CreateMap<Product, ProductReadDto>();
            CreateMap<ProductCreateDto, Product>();
        }
    }
}
