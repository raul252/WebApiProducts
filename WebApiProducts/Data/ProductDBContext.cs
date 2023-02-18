using Microsoft.EntityFrameworkCore;
using WebApiProducts.Models;

namespace WebApiProducts.Data
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options):base(options)
        {

        }

        //Create DB Set
        public DbSet<Product> Products { get; set; }
    }
}
