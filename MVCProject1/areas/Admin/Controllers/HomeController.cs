using Microsoft.AspNetCore.Mvc;

namespace MVCProject1.areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
