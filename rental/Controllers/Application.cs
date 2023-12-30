using Microsoft.AspNetCore.Mvc;

namespace rental.Controllers
{
    public class Application : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
