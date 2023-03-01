using eTickets5._0.Models;

namespace eTickets5._0.Data.Services
{
    public interface IMoviesService
    {
        //ListMovies

        Task<IEnumerable<Movie>> ListMovies();

        //get the id
        Task<Movie> GetMoviebyId(int id);
        //add the movie
        Task CreateMovie(Movie movie);

        //Update the movie

        Task UpdateMovie(int id, Movie movie);

        Task DeleteMovie(int id);
    
    }
}
