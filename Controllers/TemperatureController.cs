using Microsoft.AspNetCore.Mvc;

namespace HandsOn.Controllers 
{
    [Route("/api/[controller]")]
    public class TemperatureController : Controller 
    {

        [HttpGet()]
        public IActionResult Get() 
        {
            return Json(new {Values = new [] {1,2,4}});
        }
    }

}