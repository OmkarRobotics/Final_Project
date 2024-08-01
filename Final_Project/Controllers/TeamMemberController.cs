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
        private readonly TeamMemberContextDAO _context;
        public TeamMemberController(ILogger<TeamMemberController> logger, TeamMemberContextDAO context)
        {
            _logger = logger;
            _context = context;
        }
        
        [HttpPost]
        public IActionResult Create(int id, string name, string birthdate, string program, string year)
        {
            
            if(_context.AddMember(id, name, birthdate, program, year) > 0)
            {
                return Ok("Team member added.");
            } else
            {
                return Ok("An internal error occurred.");
            }
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(_context.GetMember(id));
        }
    }
}
