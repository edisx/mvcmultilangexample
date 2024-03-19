using Microsoft.AspNetCore.Mvc;
using mvcmultilangexample.Models;
using System.Diagnostics;
using System.Globalization;

namespace mvcmultilangexample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            // Set the culture to French
            Thread.CurrentThread.CurrentCulture = new CultureInfo("lt-LT");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("lt-LT");

            // Now create and return the view model as normal
            return View(new UserViewModel());
        }


        public IActionResult Privacy()
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
