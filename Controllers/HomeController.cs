using System.Threading.Tasks;
using HandsOn.Models;
using HandsOn.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HandsOn
{
    public class HomeController : Controller
    {
        IFloorMonitor _model;
        public HomeController(IFloorMonitor model){
            _model = model; 
        }
        public async Task<IActionResult> Index()
        {
            var temperature = await _model.GetTemperatureAsync();
            var vm = new IndexViewModel 
            {
                CurrentTemperature = new TileViewModel
                {
                    Value = $"{temperature} °C",
                    Description = "Current temperature"
                }
            };
            return View(vm);
        }
    }
}