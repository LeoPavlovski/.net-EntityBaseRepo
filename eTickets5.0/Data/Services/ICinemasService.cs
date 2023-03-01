using eTickets5._0.Models;

namespace eTickets5._0.Data.Services
{
    public interface ICinemasService
    {
        //List all of the cinemas

        Task<IEnumerable<Cinema>> GetAllCinemas();
        Task AddCinema(Cinema cinema);
        Task<Cinema> GetCinemaById(int id);
        Task<Cinema> UpdateCinema(int id, Cinema cinema);
        Task Deletecinema(int id);

    }
}
