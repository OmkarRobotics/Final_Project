using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    [ApiController]  
    [Route("[controller]")]
    public class TeamMemberController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private List<TeamMember> members;
        private readonly ILogger<TeamMemberController> _logger;

        public TeamMemberController(ILogger<TeamMemberController> logger)
        {
            _logger = logger;
            members = new List<TeamMember>();
        }

        [HttpPost]
        public IActionResult Create(string name, string birthdate, string program, string year)
        {
            members.Add(new TeamMember(name, birthdate, program, year));
            return Ok();
        }
        
    }
}
