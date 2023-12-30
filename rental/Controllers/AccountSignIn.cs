using Microsoft.AspNetCore.Mvc;

namespace rental.Controllers
{
    public class AccountSignIn : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TenantSignIn()
        {
            //logic ari
            return View();
        }
        public IActionResult AdminSignIn()
        {
            return View();
        }
    }
}
