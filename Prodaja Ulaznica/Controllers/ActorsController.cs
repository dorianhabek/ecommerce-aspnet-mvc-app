using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prodaja_Ulaznica.Data;

namespace Prodaja_Ulaznica.Controllers
{
    //contoleri su c# klase koji kontoliraju kako korisnik interacta sa mvc aplikacijom
    //hendlaju user requestove, te vraćaju response
    //treba biti kontoler za svaki sadržaj
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context; //dbcontext inject

        public ActorsController(AppDbContext contex)

        {
            _context = contex;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Actors.ToListAsync();
            return View(data);
        }
    }
}
