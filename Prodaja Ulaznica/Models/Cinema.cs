using System.ComponentModel.DataAnnotations;

namespace Prodaja_Ulaznica.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //relation
        public List<Movie> Movies { get; set; }
    }
}
