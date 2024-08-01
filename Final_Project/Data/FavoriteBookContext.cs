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
                new FavoriteBook(1, "Omkar Seth", "11/12", "College Credit Plus", "Freshman"),
                new FavoriteBook(2, "Sunav Adhikari", "01/8", "College Credit Plus", "Freshman"),
                new FavoriteBook(3, "Nathan Dahlquist", "07/29", "Information Technology", "Junior"),
                new FavoriteBook(4, "Sydney Hutton", "02/18", "Information Technology", "Junior")
                );
        }

        public DbSet<FavoriteBook> FavoriteBooks { get; set; }
    }
}
