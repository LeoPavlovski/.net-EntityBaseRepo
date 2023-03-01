using eTickets5._0.Data;
using eTickets5._0.Data.Services;
using eTickets5._0.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets5._0.Controllers
{
    public class ActorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IActorsService _service;
        public ActorsController(ApplicationDbContext context, IActorsService service)
        {
            _context = context;
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllActors();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL","Name","Biography")]Actor actor)
        {
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }
      
        public async Task<IActionResult> Details(int id)
        {
            var data = await _service.GetActorByIdAsnyc(id);
            return View(data);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetActorByIdAsnyc(id);
            return View(actorDetails);
        } 

        [HttpPost]
        public async Task<IActionResult>Edit(int id,[Bind("Id","ProfilePictureURL","Name","Biography")]Actor actor)
        {
            //We are going to update.

            var actorDetails = await _service.UpdateActorAsync(id,actor);
            return RedirectToAction(nameof(Index));
            
        }
        public async Task<IActionResult> Delete(int id)
        {
            var actorsDetaisl = await _service.GetActorByIdAsnyc(id);
            return View(actorsDetaisl);
        }
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed (int id)
        {
          var actorsDetails = await _service.GetActorByIdAsnyc(id);
          await  _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index)); 
           
        }


        //Here we are going to have the HTTP Post request.

    }
}
