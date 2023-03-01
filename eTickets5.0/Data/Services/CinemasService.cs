using eTickets5._0.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets5._0.Data.Services
{
    public class CinemasService : ICinemasService
    {

        private readonly ApplicationDbContext _context;
        public CinemasService(ApplicationDbContext context)
        {
            _context = context;   
        }
        public async Task AddCinema(Cinema cinema)
        {
            //we dont need the id here to add the cinema which means.
            await _context.AddAsync(cinema);
            await _context.SaveChangesAsync();
        }

        public async Task Deletecinema(int id)
        {
            var result =await _context.Cinemas.FirstOrDefaultAsync(x => x.Id == id);
            _context.Cinemas.Remove(result);
           await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Cinema>> GetAllCinemas()
        {
            //We don't need the id or the object we jut need to list them
            var result = await _context.Cinemas.ToListAsync();
            return result;
            
        }

        public async Task<Cinema> GetCinemaById(int id)
        {
            var result = await _context.Cinemas.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<Cinema> UpdateCinema(int id, Cinema newCinema)
        {
            _context.Update(newCinema);
            await _context.SaveChangesAsync();
            return newCinema;

        }

        
    }
}
