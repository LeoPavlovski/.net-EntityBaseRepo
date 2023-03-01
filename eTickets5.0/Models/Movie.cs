using eTickets5._0.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets5._0.Models
{
    public class Movie
    {
        //Name,Description,price,startdate,enddate,imageURL
        //This is diff for the movies gnna continue.

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ImageURL { get; set; }

        public MovieCategory MovieCategory { get; set; }

        //Relationships

        public List<Actor_Movie> Actors_Movies { get; set; }

        public Cinema Cinema { get; set; }
        [ForeignKey("CinemaId")]
        public int CinemaId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
        public int ProducerId { get; set; } 

        
    }
}
