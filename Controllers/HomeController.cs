using Microsoft.AspNetCore.Mvc;

namespace HandsOn.Controllers { 
    public class HomeController : Controller 
    {
        public IActionResult Index() {
            return View();
        }
    }
}