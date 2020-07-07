using GardenStore.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace GardenStore.Server.Data
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
        {
                
        }
        public DbSet<Product> Products { get; set; }
    }
}
