using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HobbyController : ControllerBase
    {
        private readonly ILogger<HobbyController> _logger;
        private readonly ApplicationDBContext _context;

        public HobbyController(ILogger<HobbyController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(string name, string hobbyName, string description, int frequency)
        {
            foreach (var member in _context.Hobbies)
            {
                if (member.Name.Equals(name) && member.HobbyName.Equals(hobbyName) && member.Description.Equals(description) && member.FrequencyPerWeek == frequency)
                {
                    return StatusCode(400, "This data element already exists");
                }
            }
            if (_context.AddHobby(name, hobbyName, description, frequency) > 0)
            {
                return Ok("Hobby added.");
            }
            else
            {
                return StatusCode(500, "An internal error occurred.");
            }
        }

        [HttpGet]
        public IActionResult Read(int? id)
        {
            if (_context.GetHobby(id).Count == 1)
            {
                return Ok(_context.GetHobby(id)[0]);
            }
            return Ok(_context.GetHobby(id));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (_context.DeleteHobby(id) == 1)
            {
                return Ok("Hobby deleted");
            }
            else
            {
                return StatusCode(500, "An internal error occurred.");
            }

        }

        [HttpPut]
        public IActionResult Update(Hobby hobby)
        {
            if(_context.PutHobby(hobby) == null)
            {
                return NotFound();
            }
            if(_context.PutHobby(hobby) > 0)
            {
                return Ok("Hobby updated.");
            } else
            {
                return StatusCode(500, "An internal error occurred.");
            }
        }
    }
}
