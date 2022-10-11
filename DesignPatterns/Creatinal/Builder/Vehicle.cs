using System;

namespace DesignPatterns.Creatinal.Builder
{
    public class Vehicle
    {
        public string Description { get; set; }
        public DateTime ManufacturingYear { get; set; }
        public VehicleType VehicleType { get; set; }
        public decimal Value { get; set; }
    }
}