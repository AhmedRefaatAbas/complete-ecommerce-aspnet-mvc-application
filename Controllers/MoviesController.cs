using eTickets.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> index()
        {
            var allMovies = await _context.Movies.ToListAsync();
            //dummy comment
            return View(allMovies);
        }
        
    }
}
