using Prodaja_Ulaznica.Models;

namespace Prodaja_Ulaznica.Data.Services
{
    public interface IActorsSevice
    {
        IEnumerable<Actor> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);

        void Delete(int id);
    }
}
