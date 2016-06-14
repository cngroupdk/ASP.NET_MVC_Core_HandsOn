using Microsoft.AspNetCore.Mvc;
using HandsOn.Models;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOn.Controllers
{
    [Route("/api/[controller]")]
    public class TemperatureController : Controller
    {
        private IFloorMonitor _model;
        public TemperatureController(IFloorMonitor model)
        {
            _model = model;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            /*
            {
                labels: [1,2,3]
                series: [[1,2,3]]
            }
            */
            var history = (await _model.GetHistoryAsync()).OrderBy(m=>m.Time);
            var result = new {
                Labels =  history.Select(m=>m.Time.ToString("t")).ToList(),
                Data = history.Select(m=>m.Temperature).ToList()
            };
            return Json(result);
        }


    }
}