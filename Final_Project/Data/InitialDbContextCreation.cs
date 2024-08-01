using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data
{
    public class InitialDbContextCreation : IDesignTimeDbContextFactory<ApplicationDBContext>
    {
      
        
            public  InitialDbContextCreation CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();
                optionsBuilder.UseSqlite("Data Source=blog.db");

                return new ApplicationDBContext(optionsBuilder.Options);
            }
        
    }
}
