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
        private readonly ApplicationDBContext _context;
        public TeamMemberController(ILogger<TeamMemberController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        [HttpPost]
        public IActionResult Create(string name, string birthdate, string program, string year)
        {
            foreach(var member in _context.TeamMembers)
            {
                if(member.Name.Equals(name) && member.Birthdate.Equals(birthdate) && member.CollegeProgram.Equals(program) && member.Year.Equals(year))
                {
                    return StatusCode(500, "An internal error occurred.");
                }
            }
            if(_context.AddMember(name, birthdate, program, year) > 0)
            {
                return Ok("Team member added.");
            } else
            {
                return StatusCode(500,"An internal error occurred.");
            }
        }
        [HttpGet]
        public IActionResult Read(int? id)
        {
            if(_context.GetMember(id).Count == 1)
            {
                return Ok(_context.GetMember(id)[0]);
            }
            return Ok(_context.GetMember(id));
        }
    }
}
