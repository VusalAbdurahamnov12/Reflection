using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection.Models
{
    public abstract class Vehicle
    {
        public abstract double DriveTime { get; set; }
        public abstract double DrivePath { get; set; }

        public double AverageSpeed()
        {
            return Math.Round(DrivePath / DriveTime, 2);
        }
    }
}
