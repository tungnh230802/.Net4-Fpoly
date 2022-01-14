using lab7.Models;
using Microsoft.EntityFrameworkCore;

namespace lab7.Data
{
   public class ProductDbContext : DbContext
   {
       public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
       {

       }
        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);
        }

        
       public DbSet<ProductModel> Products {get;set;}
   } 
}