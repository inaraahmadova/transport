using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace transport
{
    abstract class Vehicle
    {
        string _factoryName;
        string _model;
        string _color;
        double _driveTime;
        double _drivePath;

        public string factoryName
        {
            get { return _factoryName; }
            set { _factoryName = value; }
        }
        public string model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string color
        {
            get
            {return _color;}
            set { _color = value; }
        }
        public double driveTime
        { 
            get { return _driveTime; }
            set { _driveTime = value; }
        }
        public double drivePath
        {
            get { return _drivePath; }
            set { _drivePath = value; }
        }

        protected Vehicle(string factoryName, string model, string color, double driveTime, double drivePath)
        {
            _factoryName = factoryName;
            _model = model;
            _color = color;
            _driveTime = driveTime;
            _drivePath = drivePath;
        }

        public double AverageSpeed()
        {
            return _drivePath / _driveTime;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Factory: {factoryName}, Model: {model}, Color: {color}, Average Speed: {AverageSpeed()} km/saat");
        }
        public override string ToString()
        {
            return $"Factory: {factoryName}, Model: {model}";
        }
        public abstract string DefineNatureHarmness();
    }
}
