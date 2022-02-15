using Microsoft.EntityFrameworkCore;

namespace Bai1.Models
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext()
        {

        }
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base (options)
        {

        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
