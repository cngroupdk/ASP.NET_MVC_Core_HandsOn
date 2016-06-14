using System.Collections.Generic;
using System.Threading.Tasks;

namespace HandsOn.Models
{
    public interface IFloorMonitor
    {
        Task<decimal> GetTemperatureAsync();
        Task<int> GetSensorCountAsync();
        Task<List<Alert>> GetAlertsAsync();
        Task<List<TemperatureMeasurement>> GetHistoryAsync();
    }
}