using Microsoft.EntityFrameworkCore;
using WebApplication6.Data.Entities;

namespace WebApplication6.Data
{
    public class FoodDbContext : DbContext
    {
        public FoodDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Food> Foods { get; set; }
    }
}
