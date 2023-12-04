using Microsoft.EntityFrameworkCore;
using Shop.DB.Entities;

namespace Shop;

public class DataBaseContext : DbContext
{
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<PriceListPosition> PriceListPositions { get; set; }
    public DbSet<PriceList> PriceLists { get; set; }
    public DbSet<Currency> Currencies { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<CustomerState> CustomerStates { get; set; }
    public DbSet<CustomerType> CustomerTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(
            "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=SchoolShopDb;Integrated Security=True");
    }
}