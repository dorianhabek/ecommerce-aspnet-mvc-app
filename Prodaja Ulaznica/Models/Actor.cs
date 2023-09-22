using System.ComponentModel.DataAnnotations;

namespace Prodaja_Ulaznica.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name = "Profile picture ")]//Display data notation

        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full name")]
        public string FullName { get; set; }

        [Display(Name = "Bio")]
        public string Bio { get; set; }

       

        //relation
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
