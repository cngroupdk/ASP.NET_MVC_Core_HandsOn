using Microsoft.AspNetCore.Mvc;
using HandsOn.Models;
using System.Threading.Tasks;
using System.Linq;
using HandsOn.ViewModels;

namespace HandsOn.Components
{
    public class AlertsViewComponent : ViewComponent
    {
        IFloorMonitor _model;

        public AlertsViewComponent(IFloorMonitor model)
        {
            _model = model;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var alerts = await _model.GetAlertsAsync();
            var vm = alerts.Select(a => new AlertViewModel { 
                    Source = a.Source, 
                    Message = a.Message 
                }).ToList();
                
            return View(vm);
        }
    }
}