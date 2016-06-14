using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOn.Models
{
    public class FloorMonitor : IFloorMonitor
    {
        private readonly List<TemperatureMeasurement> _measurements;

        public FloorMonitor()
        {
            _measurements = new List<TemperatureMeasurement>
            {
                new TemperatureMeasurement
                {
                    Sensor = 1,
                    Temperature = 29,
                    Time = DateTime.Now.AddHours(-3)
                },
                new TemperatureMeasurement
                {
                    Sensor = 2,
                    Temperature = 26,
                    Time = DateTime.Now.AddHours(-2)
                },
                new TemperatureMeasurement
                {
                    Sensor = 1,
                    Temperature = 21,
                    Time = DateTime.Now.AddHours(-1)
                },
                new TemperatureMeasurement
                {
                    Sensor = 1,
                    Temperature = 23,
                    Time = DateTime.Now
                }
            };
        }

        public decimal OptimalTemperature { get; set; } = 23;

        public Task<decimal> GetTemperatureAsync()
        {
            return Task.FromResult(_measurements.Last().Temperature);
        }

        public Task<int> GetSensorCountAsync()
        {
            return Task.FromResult(_measurements.Select(m => m.Sensor).Distinct().Count());
        }

        public Task<List<Alert>> GetAlertsAsync()
        {
            return Task.Run(() => _measurements.Where(m => m.Temperature > OptimalTemperature)
                .Select(m => new Alert {Source = $"Sensor{m.Sensor}", Message = "Temperature is not optimal."})
                .ToList());
        }

        public Task<List<TemperatureMeasurement>> GetHistoryAsync()
        {
            return Task.FromResult(_measurements);
        }
    }
}