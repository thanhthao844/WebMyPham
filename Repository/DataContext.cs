using Microsoft.EntityFrameworkCore;
using WebMyPham_DOANPM.Models;

namespace WebMyPham_DOANPM.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<BrandModel> Brands { get; set; }

        public DbSet<ProductModel> Products { get; set; }   

        public DbSet<CategoryModel> Category { get; set; }

        public DbSet<ProductVariant> ProductVariants { get; set; }
    }
}
