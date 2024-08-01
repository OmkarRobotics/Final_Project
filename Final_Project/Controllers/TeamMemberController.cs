using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    [ApiController]  
    [Route("[controller]")]
    public class TeamMemberController : ControllerBase
    {
        
        private readonly ILogger<TeamMemberController> _logger;
        private readonly TeamMemberContext _context;
        public TeamMemberController(ILogger<TeamMemberController> logger, TeamMemberContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(int id, string name, string birthdate, string program, string year)
        {
            
            _context.TeamMembers.Add(new TeamMember(id, name, birthdate, program, year));
            return Ok();
        }
        
    }
}
