using eTickets5._0.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets5._0.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly ApplicationDbContext _context;
        public ActorsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

        public Task<Actor> GetActorByIdAsnyc(int id)
        {
           var data = _context.Actors.FirstOrDefaultAsync(a => a.Id == id);
           return data;
        }

        public async Task<IEnumerable<Actor>> GetAllActors()
        {
            var data = await _context.Actors.ToListAsync();
            return data;
        }

        public async Task<Actor> UpdateActorAsync(int id, Actor actor)
        {
            //we are going to save the changes. //we need the new actor.

             _context.Update(actor);
            await _context.SaveChangesAsync();
            return actor;
           

        }
    }
}
