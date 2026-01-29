using System;

namespace NobleDomain.Models
{
    public class Sensor
    {
        public int SensorId { get; set; }

        public string? SensorName { get; set; }

        public string? SensorType { get; set; }

        public string? Location { get; set; }

        public double? LastReading { get; set; } 
    }
}
