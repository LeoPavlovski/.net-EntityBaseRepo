using eTickets5._0.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets5._0.Data.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly ApplicationDbContext _context;
        public MoviesService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateMovie(Movie movie)
        {
           await _context.Movies.AddAsync(movie);
           await _context.SaveChangesAsync();
        }

        public Task DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetMoviebyId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> ListMovies()
        {
            var result =await _context.Movies.ToListAsync();
            return result;
        }

        public Task UpdateMovie(int id, Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
