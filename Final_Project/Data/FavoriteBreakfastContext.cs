using Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data
{
    public class FavoriteBreakfastkContext : DbContext
    {
        public FavoriteBreakfastContext(DbContextOptions<FavoriteBreakfastContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FavoriteBreakfastk>().HasData(
                new FavoriteBreakfast (1, "Omkar Seth", "Animal Farm", 5.99, "08/17/1945"),
                new FavoriteBreakfast (2, "Sunav Adhikari", "Harry Potter and the Goblet of Fire", 9.95, "07/08/2000"),
                new FavoriteBreakfast (3, "Nathan Dahlquist", "House of Leaves", 14.95, "03/07/2000"),
                new FavoriteBreakfast (4, "Sydney Hutton", "Ms.Peregrines Home for Peculiar Children", 12.99, "06/07/2011")
                );
        }

        public DbSet<FavoriteBook> FavoriteBooks { get; set; }
    }
}