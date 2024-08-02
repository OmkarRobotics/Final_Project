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
        public IActionResult Create(int id, string name, string description, int frequency)
        {
            if (_context.AddHobby(id, name, description, frequency) > 0)
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
    }
}
