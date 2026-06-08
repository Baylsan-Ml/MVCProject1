using Microsoft.AspNetCore.Mvc;
using MVCProject1.Data;
using MVCProject1.Models;
using System.Diagnostics;

namespace MVCProject1.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext context = new ApplicationDbContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.categories = context.Categories.ToList();
            ViewBag.products = context.Products.ToList();
            return View();
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
