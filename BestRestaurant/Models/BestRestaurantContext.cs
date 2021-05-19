using Microsoft.EntityFrameworkCore;

namespace BestRestaurant.Models
{
  public class BestRestaurantContext : DbContext
  {
    public virtual DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Dish> Dishes { get; set; }

    public BestRestaurantContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}