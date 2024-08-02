using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteBookController : ControllerBase
    {
        private readonly ILogger<FavoriteBookController> _logger;
        private readonly ApplicationDBContext _context;

        public FavoriteBookController(ILogger<FavoriteBookController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(string name, string title, double price, string publishedDate)
        {
            if (_context.AddFavoriteBook(name, title, price, publishedDate) > 0)
            {
                return Ok("Favorite book added.");
            }
            else
            {
                return StatusCode(500, "An internal error occurred.");
            }
        }

        [HttpGet]
        public IActionResult Read(int? id)
        {
            if (_context.GetFavoriteBook(id).Count == 1)
            {
                return Ok(_context.GetFavoriteBook(id)[0]);
            }
            return Ok(_context.GetFavoriteBook(id));
        }
    }
}
