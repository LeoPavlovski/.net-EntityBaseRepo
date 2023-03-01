using eTickets5._0.Models;

namespace eTickets5._0.Data.Services
{
    public interface IActorsService
    {
        //We are going to define all of the methods here.

        //Create options

        //List all of the items

        Task<IEnumerable<Actor>> GetAllActors();

        //Create an Actor

        //We are going to need the task, because we want to upload so get the index, with a view and return the HTTPPost requrest.
        Task AddAsync(Actor actor);

        //Get the id of the actor (so we could update, and get the details for that same actor)
        Task<Actor> GetActorByIdAsnyc(int id);

        //Edit

        Task<Actor> UpdateActorAsync(int id, Actor actor);

        Task DeleteAsync(int id);



    }
}
