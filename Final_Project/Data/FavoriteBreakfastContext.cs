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
                new FavoriteBreakfast (1, "Omkar Seth", "Waffles","A crispy batter cake with a gridlike design", 2.97),
                new FavoriteBreakfast (2, "Sunav Adhikari", "Pancakes","circular baked pancake mix", 4.95),
                new FavoriteBreakfast (3, "Nathan Dahlquist","Hash Browns", "Fried potato slices", 4.45),
                new FavoriteBreakfast (4, "Sydney Hutton", "Bagels" "Two pieces of tooasted bread with creamcheese", 4.95)
                );
        }

        public DbSet<FavoriteBreakfast> FavoriteBreakfasts { get; set; }
    }
}