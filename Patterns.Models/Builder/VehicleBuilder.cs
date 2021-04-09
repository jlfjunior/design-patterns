using System;

namespace Patterns.Models.Builder
{
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder(string x, DateTime y, decimal v)
        {
            Init();
            Build(x, y, v);
            BuildType();
        }

        public override void BuildType()
        {
            Vehicle.VehicleType = VehicleType.Automobile;
        }
    }

    public class MotocycleBuilder : VehicleBuilder
    {
        public MotocycleBuilder(string x, DateTime y, decimal v)
        {
            Init();
            Build(x, y, v);
            BuildType();
        }

        public override void BuildType()
        {
            Vehicle.VehicleType = VehicleType.Motocycle;
        }
    }

    public abstract class VehicleBuilder
    {
        protected Vehicle Vehicle;


        protected void Init()
        {
            Vehicle = new Vehicle();
        }

        public Vehicle GetVehicle()
        {
            return Vehicle;
        }

        public abstract void BuildType();

        protected void Build(string description, DateTime date, decimal value)
        {
            Vehicle.Value = value;
            Vehicle.Description = description;
            Vehicle.ManufacturingYear = date;
        }
    }

    public enum VehicleType
    {
        Motocycle = 4,
        Automobile = 7,
    }
}