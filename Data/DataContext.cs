using Microsoft.EntityFrameworkCore;
using pizzaAPI_csharp.Models;

namespace pizzaAPI_csharp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Order> Order { get; set; }
    }  
}
