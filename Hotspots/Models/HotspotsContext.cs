using Microsoft.EntityFrameworkCore;

namespace Hotspots.Models
{
  public class HotspotsContext : DbContext
  {
    public HotspotsContext(DbContextOptions<HotspotsContext> options) : base(options)  {}
    
    public DbSet<Restaurant> Restaurants { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

        builder.Entity<Restaurant>()
        .HasData(
          new Restaurant { Name = "Battle Cafe", Id = 1, City = "Blackburn", Cuisine = "Brunch" },
          new Restaurant { Name = "Higher Ground", Id = 2, City = "Melbourne", Cuisine = "Brunch" },
          new Restaurant { Name = "Marion", Id = 3, City = "Fitzroy", Cuisine = "Modern Fine" },
          new Restaurant { Name = "Terror Twilight", Id = 4, City = "Collingwood", Cuisine = "Brunch" },
          new Restaurant { Name = "Embla", Id = 5, City = "Melbourne", Cuisine = "Modern Fine"},
          new Restaurant { Name = "Bar Liberty", Id = 6, City = "Collingwood", Cuisine = "Modern Fine" },

          new Restaurant { Name = "Peaches", Id = 7, City = "Melbourne", Cuisine = "Bar/Tapas" },
          new Restaurant { Name = "Cookie", Id = 8, City = "Melbourne", Cuisine = "Bar/Thai" },
          new Restaurant { Name = "Holy Basil", Id = 9, City = "Sydney", Cuisine = "Thai" },
          new Restaurant { Name = "El Jannah", Id = 10, City = "Sydney", Cuisine = "Chicken Shop" },
          new Restaurant { Name = "Hectors Deli", Id = 11, City = "Richmond", Cuisine = "Sandwiches"},
          new Restaurant { Name = "Red Sparrow Pizza", Id = 12, City = "Collingwood", Cuisine = "Vegan/Pizza" }
        );
    }
  } 
}