
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HandsOn.Components 
{
    public class AlertsViewComponent : ViewComponent 
    {
        public async Task<IViewComponentResult> InvokeAsync() {
            var result =  await Task.FromResult("42");
            return View((object)result);
        }

    }
}