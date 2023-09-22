using Microsoft.AspNetCore.Mvc;
using Prodaja_Ulaznica.Models;
using System.Diagnostics;

namespace Prodaja_Ulaznica.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }




    }
}