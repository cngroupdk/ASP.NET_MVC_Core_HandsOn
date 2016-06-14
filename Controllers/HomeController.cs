using Microsoft.AspNetCore.Mvc;

namespace HandsOn
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}