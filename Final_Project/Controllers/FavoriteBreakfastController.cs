using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteBreakfastController : ControllerBase
    {
        private readonly ILogger<FavoriteBreakfastController> _logger;
        private readonly ApplicationDBContext _context;

        public FavoriteBreakfastController(ILogger<FavoriteBreakfastController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(int id, string name, string breakfastName, string description, double price)
        {
            if (_context.AddFavoriteBreakfast(id, name, breakfastName, description, price) > 0)
            {
                return Ok("Favorite breakfast added.");
            }
            else
            {
                return StatusCode(500, "An internal error occurred.");
            }
        }

        [HttpGet]
        public IActionResult Read(int? id)
        {
            if (_context.GetFavoriteBreakfast(id).Count == 1)
            {
                return Ok(_context.GetFavoriteBreakfast(id)[0]);
            }
            return Ok(_context.GetFavoriteBreakfast(id));
        }
    }
}
