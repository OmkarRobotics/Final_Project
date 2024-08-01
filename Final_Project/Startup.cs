using Final_Project.Data;
using Final_Project.Interfaces;
using Microsoft.AspNetCore.Builder; 
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting; 
namespace Final_Project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;  
        
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        { 
            services.AddControllers();
            services.AddSwaggerDocument();
            services.AddDbContext<TeamMemberContext>(options => options.UseSqlServer(Configuration.GetConnectionString("TeamMemberContext"))); // check connection string is correct 
            services.AddScoped<ITeamMemberContextDAO, TeamMemberContextDAO>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, TeamMemberContext context) 
        {
            if (env.IsDevelopment())
            { 
                app.UseDeveloperExceptionPage();
            }
            app.UseOpenApi();
            app.UseSwaggerUI(); // maybe add 3   
            context.Database.Migrate();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
