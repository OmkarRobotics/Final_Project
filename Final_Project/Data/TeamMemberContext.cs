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
                new TeamMember (1, "Omkar Seth", "11/12","College Credit Plus","Freshman" ),
                new TeamMember (2, "Sunav Adhikari", "01/8", "College Credit Plus", "Freshman"),
                new TeamMember (3, "Nathan Dahlquist", "07/29", "Information Technology", "Junior" ),
                new TeamMember (4, "Sydney Hutton", "02/18", "Information Technology", "Junior" )
                );
        }

        public DbSet<TeamMember> TeamMembers { get; set; }

        public int AddMember(int id, string name, string birthdate, string program, string year)
        {
            foreach(var member in TeamMembers)
            {
                if(member.Id == id)
                {
                    return -1;
                }
            }
            try
            {
                TeamMembers.Add(new TeamMember(id, name, birthdate, program, year));
            } catch(Exception ex)
            {
                return -1;
            }
            return 1;
        }
    }
}
