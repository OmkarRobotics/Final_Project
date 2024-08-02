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
            foreach (var member in _context.FavoriteBooks)
            {
                if (member.Name.Equals(name) && member.BookName.Equals(title) && member.BookPrice == price && member.ReleaseDate.Equals(publishedDate))
                {
                    return StatusCode(400, "This data element already exists");
                }
            }
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


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (_context.DeleteFavoriteBook(id) == 1)
            {
                return Ok("Favorite book deleted");
            }
            else
            {
                return StatusCode(500, "An internal error occurred.");
            }

        }

        [HttpPut]
        public IActionResult Update(FavoriteBook favoriteBook)
        {
            if (_context.PutFavoriteBook(favoriteBook) == null)
            {
                return NotFound();
            }
            if (_context.PutFavoriteBook(favoriteBook) > 0)
            {
                return Ok("Favorite book updated.");
            }
            else
            {
                return StatusCode(500, "An internal error occurred.");
            }
        }
    }
}
