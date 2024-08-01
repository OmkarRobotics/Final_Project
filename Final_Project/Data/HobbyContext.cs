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
				new Hobby("Sydney Hutton", "Art", "Creating collages", "3"),
				new Hobby("Nathan Dahlquist", "Vintage Tech Collecting", "Collecting and learning about retro hardware, especially video game related", "2"),
				new Hobby("Sunav Adhikari", "Swimming", "null", "5"),
				new Hobby("Seth Omkar", "", " ", "")

			);
		}

		public DbSet<Hobby> Hobbies { get; set; }
	}
}
