using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HairCity.Models;

namespace HairCity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Aanbod()
        {
            return View("aanbod");
        }

        public IActionResult Tarieven()
        {
            return View("tarieven");
        }

        public IActionResult Afspraak()
        {
            return View("afspraak");
        }

        public IActionResult Praktisch()
        {
            return View("praktisch");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
