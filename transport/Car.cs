using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport
{
    internal class Car:Vehicle
    {
         int _doorCount { get; set; }
         bool _isElectricCar { get; set; }
        public Car(string factoryName, string model, string color, double driveTime, double drivePath, int doorCount, bool isElectricCar) 
            : base(factoryName, model, color, driveTime, drivePath)
        {
            _doorCount = doorCount;
            _isElectricCar = isElectricCar;
        }
        

        public override string DefineNatureHarmness()
        {
            return "car";
        }
    }
}
