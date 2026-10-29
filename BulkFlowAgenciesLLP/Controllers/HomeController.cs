using System.Diagnostics;
using BulkFlowAgenciesLLP.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkFlowAgenciesLLP.Controllers
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

        public IActionResult Aboutus()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Ourproducts()
        {
            return View();
        }
        public IActionResult ChemicalRoadTankerLayout()
        {
            return View();
        }
        public IActionResult ISOTankerLayout()
        {
            return View();
        }
        public IActionResult IBCOffshoreTankerLayout()
        {
            return View();
        }
        public IActionResult RailTankerLayout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
