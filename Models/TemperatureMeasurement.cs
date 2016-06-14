using System;

namespace HandsOn.Models
{
    public class TemperatureMeasurement
    {
        public decimal Temperature { get; set; }
        public DateTime Time { get; set; }
        public int Sensor { get; set; }
    }
}