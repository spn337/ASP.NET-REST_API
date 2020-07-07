using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GardenStore.Server.Models
{
    [Table("tblProducts")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

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

        //[ForeignKey("Category")]
        //public int? CategoryId { get; set; }
        //public virtual Category Category { get; set; }
    }
}
