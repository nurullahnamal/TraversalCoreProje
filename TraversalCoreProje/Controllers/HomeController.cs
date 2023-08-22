using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            _logger.LogInformation("Index Sayfası çağırıldı");
            _logger.LogError("Error Log Çağırıldı");
            return View();
        }

        public IActionResult Privacy()
        {
            DateTime d=Convert.ToDateTime(DateTime.Now.ToLongDateString());
            _logger.LogInformation(d+"   Privacy Sayfası çağırıldı");

            return View();
        }

        public IActionResult Test()
        {
            _logger.LogInformation("Test sayfası cagırıldı");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}