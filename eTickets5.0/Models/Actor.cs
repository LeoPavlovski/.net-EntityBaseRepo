using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eTickets5._0.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="The name is required")]
        [Display(Name="Full Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The profile Picture is required")]
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Required(ErrorMessage = "The biography is required")]
        [Display(Name = "Biography")]
        public string Biography { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
