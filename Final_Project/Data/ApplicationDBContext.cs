using Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamMember>().HasData(
                new TeamMember(1, "Omkar Seth", "11/12", "College Credit Plus", "Freshman"),
                new TeamMember(2, "Sunav Adhikari", "01/8", "College Credit Plus", "Freshman"),
                new TeamMember(3, "Nathan Dahlquist", "07/29", "Information Technology", "Junior"),
                new TeamMember(4, "Sydney Hutton", "02/18", "Information Technology", "Junior")
                );

            builder.Entity<FavoriteBook>().HasData(
                new FavoriteBook(1, "Omkar Seth", "Animal Farm", 5.99, "08/17/1945"),
                new FavoriteBook(2, "Sunav Adhikari", "Harry Potter and the Goblet of Fire", 9.95, "07/08/2000"),
                new FavoriteBook(3, "Nathan Dahlquist", "House of Leaves", 14.95, "03/07/2000"),
                new FavoriteBook(4, "Sydney Hutton", "Ms.Peregrines Home for Peculiar Children", 12.99, "06/07/2011")
                );
            builder.Entity<FavoriteBreakfast>().HasData(
                new FavoriteBreakfast(1, "Omkar Seth", "Waffles", "A crispy batter cake with a gridlike design", 2.97),
                new FavoriteBreakfast(2, "Sunav Adhikari", "Pancakes", "circular baked pancake mix", 4.95),
                new FavoriteBreakfast(3, "Nathan Dahlquist", "Hash Browns", "Fried potato slices", 4.45),
                new FavoriteBreakfast(4, "Sydney Hutton", "Bagels", "Two pieces of toasted bread with creamcheese", 4.95)
                );
            builder.Entity<Hobby>().HasData(
                new Hobby(1, "Sydney Hutton", "Art", "Creating collages", 3),
                new Hobby(2, "Nathan Dahlquist", "Vintage Tech Collecting", "Collecting and learning about retro hardware, especially video game related", 2),
                new Hobby(3, "Sunav Adhikari", "Swimming", "Breaststroke and Backstroke", 5),
                new Hobby(4, "Omkar Seth", "Piano", "Playing classical music", 3)
            );
        }

        public DbSet<FavoriteBook> FavoriteBooks { get; set; }
        public DbSet<FavoriteBreakfast> FavoriteBreakfasts { get; set; }

        public DbSet<Hobby> Hobbies { get; set; }

        public DbSet<TeamMember> TeamMembers { get; set; }

    }
}
