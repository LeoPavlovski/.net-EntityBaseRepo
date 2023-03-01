using eTickets5._0.Data;
using eTickets5._0.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets5._0.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMoviesService _service;

        public MoviesController(ApplicationDbContext context, IMoviesService service)
        {
            _context = context;
            _service = service;

        }
       public async Task<IActionResult> Index()
        {
            var result = await _service.ListMovies();
            return View(result);
           
        }
    }
}
