using System.ComponentModel.DataAnnotations;

namespace GardenStore.Server.DTOs
{
    public class ProductCreateDto
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string LongDescription { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Count { get; set; }
    }
}
