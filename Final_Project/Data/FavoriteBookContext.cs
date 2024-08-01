using Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data
{
    public class FavoriteBookContext: DbContext
    {
        public FavoriteBookContext(DbContextOptions<FavoriteBookContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FavoriteBook>().HasData(
                new FavoriteBook(1, "Omkar Seth", "Animal Farm", 5.99, "08/17/1945"),
                new FavoriteBook(2, "Sunav Adhikari", "Harry Potter and the Goblet of Fire", 9.95, "07/08/2000"),
                new FavoriteBook(3, "Nathan Dahlquist", "House of Leaves", 14.95, "03/07/2000"),
                new FavoriteBook(4, "Sydney Hutton", "Ms.Peregrines Home for Peculiar Children", 12.99, "06/07/2011")
                );
        }

        public DbSet<FavoriteBook> FavoriteBooks { get; set; }
    }
}
