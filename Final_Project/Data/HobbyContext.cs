using Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data
{
	public class HobbyContext : DbContext
	{
		public HobbyContext(DbContextOptions<HobbyContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Hobby>().HasData(
				new Hobby (1, "Sydney Hutton", "Art", "Creating collages", 3),
				new Hobby (2, "Nathan Dahlquist", "Vintage Tech Collecting", "Collecting and learning about retro hardware, especially video game related", 2),
				new Hobby (3, "Sunav Adhikari", "Swimming", "Breaststroke and Backstroke", 5),
				new Hobby (4, "Seth Omkar", "Piano", "Playing classical music", 3)
			);
		}

		public DbSet<Hobby> Hobbies { get; set; }
	}
}
