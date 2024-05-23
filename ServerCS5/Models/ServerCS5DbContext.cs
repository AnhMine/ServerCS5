using Microsoft.EntityFrameworkCore;

namespace ServerCS5.Models
{
    public class ServerCS5DbContext : DbContext
    {
        public ServerCS5DbContext(DbContextOptions dbContextoptions) : base (dbContextoptions)
        {

        }
        public DbSet<Account> Account { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<DetailOrder> DetailOrder { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
