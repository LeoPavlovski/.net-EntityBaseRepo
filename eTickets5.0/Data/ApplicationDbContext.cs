using eTickets5._0.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets5._0.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //Relationships

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.MovieId,
                am.ActorId
            });
        }

        public DbSet<Actor_Movie>Actors_Movies { get; set; }
        public DbSet<Actor>Actors { get; set; }
        public DbSet<Producer>Producers { get; set; }
        public DbSet<Movie>Movies { get; set; }
        public DbSet<Cinema>Cinemas { get; set; }
 
    }
}
