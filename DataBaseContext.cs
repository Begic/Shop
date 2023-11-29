using Microsoft.EntityFrameworkCore;
using Shop.DB.Entities;

namespace Shop
{

    public class DataBaseContext : DbContext
    {
        
        public DbSet<Product> Products { get; set; }



    }
}
