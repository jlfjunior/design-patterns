using System;
using Patterns.Models.Builder;
using Xunit;

namespace Patterns.Tests
{
    public class BuilderTest
    {
        [Fact]
        public void ShouldGetCar()
        {
            var director = new Director(new CarBuilder("", DateTime.Now, 123.1m));
            var car = director.VehicleBuilder.GetVehicle();

            Assert.Equal(VehicleType.Automobile, car.VehicleType);
        }

        [Fact]
        public void ShouldGetMotocycle()
        {
            var director = new Director(new MotocycleBuilder("", DateTime.Now, 123.2m));
            var motocycle = director.VehicleBuilder.GetVehicle();

            Assert.Equal(VehicleType.Motocycle, motocycle.VehicleType);
        }
    }
}