using Microsoft.AspNetCore.Mvc;

namespace WebApplicationOne.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
