using Microsoft.AspNetCore.Mvc;

namespace JWTAPP.FRONT.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
