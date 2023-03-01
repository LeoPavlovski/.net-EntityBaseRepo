using eTickets5._0.Data;
using eTickets5._0.Data.Services;
using eTickets5._0.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets5._0.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICinemasService _service;

        public CinemasController(ApplicationDbContext context, ICinemasService service)
        {
            _context = context;
            _service= service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllCinemas();
            return View(data);
        }
        //GET::/actors/create

        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Create([Bind("ProfilePictureURL", "Name", "Biography")]Cinema cinema)
        {
            await _service.AddCinema(cinema);
            return RedirectToAction(nameof(Index));
            
        }
        public async Task<IActionResult> Details(int id)
        {
            var result = await _service.GetCinemaById(id);
            return View(result);
        }
        //Edit the cinema

        public async Task<IActionResult> Edit(int id)
        {
            var result = await _service.GetCinemaById(id);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id","ProfilePictureURL","Name","Biography")]Cinema cinema)
        {
            await _service.UpdateCinema(id, cinema);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var cinemaDetails = await _service.GetCinemaById(id);
            return View(cinemaDetails);

        }
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
           await _service.GetCinemaById(id);
            await _service.Deletecinema(id);
            return RedirectToAction(nameof(Index)); 
            
        }
    }
}
