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
        public IActionResult Create(string name, string breakfastName, string description, double price)
        {
            foreach (var member in _context.FavoriteBreakfasts)
            {
                if (member.Name.Equals(name) && member.BreakfastName.Equals(breakfastName) && member.Description.Equals(description) && member.Price == price)
                {
                    return StatusCode(500, "An internal error occurred.");
                }
            }
            if (_context.AddFavoriteBreakfast(name, breakfastName, description, price) > 0)
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

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (_context.DeleteFavoriteBreakfast(id) == 1)
            {
                return Ok("Favorite breakfast deleted");
            }
            else
            {
                return StatusCode(500, "An internal error occurred.");
            }

        }

        [HttpPut]
        public IActionResult Update(FavoriteBreakfast favoriteBreakfast)
        {
            if (_context.PutFavoriteBreakfast(favoriteBreakfast) == null)
            {
                return NotFound();
            }
            if (_context.PutFavoriteBreakfast(favoriteBreakfast) > 0)
            {
                return Ok("Favorite breakfast updated.");
            }
            else
            {
                return StatusCode(500, "An internal error occurred.");
            }
        }
    }
}
