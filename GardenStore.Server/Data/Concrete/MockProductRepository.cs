using GardenStore.Server.Data.Abstract;
using GardenStore.Server.Models;
using System.Collections.Generic;

namespace GardenStore.Server.Data.Concrete
{
    public class MockProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id=0,
                    Name = "Мотокосa Werk WB-5300S",
                    ShortDescription = "Бензинова мотокоса потужністю 4.76к.с.",
                    LongDescription = "Бензинова мотокоса потужністю 4.76к.с. та двотактним двигуном обємом 52 куб см. " +
                "Особливості: Автоматичне регулювання довжини волосіні, регулювання висоти ручки, ремінь на плече",
                    Price = 1599,
                    Count = 4
                },
                new Product
                {
                    Id=1,
                    Name = "Мотокосa Werk WB-5300S",
                    ShortDescription = "Бензинова мотокоса потужністю 4.76к.с.",
                    LongDescription = "Бензинова мотокоса потужністю 4.76к.с. та двотактним двигуном обємом 52 куб см. " +
                "Особливості: Автоматичне регулювання довжини волосіні, регулювання висоти ручки, ремінь на плече",
                    Price = 1599,
                    Count = 4
                },
                new Product
                {
                    Id=2,
                    Name = "Мотокосa Werk WB-5300S",
                    ShortDescription = "Бензинова мотокоса потужністю 4.76к.с.",
                    LongDescription = "Бензинова мотокоса потужністю 4.76к.с. та двотактним двигуном обємом 52 куб см. " +
                "Особливості: Автоматичне регулювання довжини волосіні, регулювання висоти ручки, ремінь на плече",
                    Price = 1599,
                    Count = 4
                }
            };
        }

        public Product GetProductById(int id)
        {
            return new Product
            {
                Id = 0,
                Name = "Мотокосa Werk WB-5300S",
                ShortDescription = "Бензинова мотокоса потужністю 4.76к.с.",
                LongDescription = "Бензинова мотокоса потужністю 4.76к.с. та двотактним двигуном обємом 52 куб см. " +
                "Особливості: Автоматичне регулювання довжини волосіні, регулювання висоти ручки, ремінь на плече",
                Price = 1599,
                Count = 4
            };
        }
    }
}
