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
    internal class Bicycle:Vehicle
    {
        string _type;
        public Bicycle(string factoryName, string model, string color, double driveTime, double drivePath, string type)
            : base(factoryName, model, color, driveTime, drivePath )
        {
            _type = type; 
        }
        public override string DefineNatureHarmness()
        {
            return "bicycle";
        }
    }
}
