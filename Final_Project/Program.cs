using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
/*
public int DeleteMember(int id)
{
    var teamMember = GetMember(id);
    if (teamMember.Count > 1)
    {
        return -1;
    }
    else
    {
        try
        {
            TeamMembers.Remove(teamMember);
            SaveChanges();
        }
        catch (Exception e)
        {
            return -1;
        }
        return 1;
    }



}*/

/*
[HttpDelete]
public IActionResult Delete(int id)
{
    if (_context.DeleteMember(id).Count == 1)
    {
        return Ok("Team member deleted");
    }
    else
    {
        return StatusCode(500, "An internal error occurred.");
    }

}*/