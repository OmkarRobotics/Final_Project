using Final_Project.Models;
using Microsoft.EntityFrameworkCore;


namespace Final_Project.Data
{
    public class TeamMemberContext : DbContext
    {
        public TeamMemberContext(DbContextOptions<TeamMemberContext> options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, Name = "Omkar Seth", Birthdate = "11/12", CollegeProgram = "College Credit Plus", Year = "Freshman" },
                new TeamMember { Id = 2, Name = "Sunav Adhikari", Birthdate = "01/8", CollegeProgram = "College Credit Plus", Year = "Freshman" },
                new TeamMember { Id = 3, Name = "Nathan Dahlquist", Birthdate = "07/29", CollegeProgram = "Information Technology", Year = "Junior" },
                new TeamMember { Id = 4, Name = "Sydney Hutton", Birthdate = "02/18", CollegeProgram = "Information Technology", Year = "Junior" }
                );
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
