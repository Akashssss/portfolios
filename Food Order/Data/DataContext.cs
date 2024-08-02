

namespace Food_Order.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { } 

        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Order> Orders { get; set; } 

        public DbSet<OrderProduct> OrderProduct { get; set; }

        public DbSet<Product> Products { get; set; }
     
    }

}
