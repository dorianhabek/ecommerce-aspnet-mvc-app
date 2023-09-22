namespace Prodaja_Ulaznica.Models
{
    public class Actor_Movie
    {
        //relation
        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        public int ActorId { get; set; }

        public Actor Actor { get; set; }
    }
}
