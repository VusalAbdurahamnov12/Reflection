using Reflection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection.Models
{
    public class Plane : Vehicle, IWheel, IEngine
    {
        private double _driveTime;
        private double _drivePath;
        private double _wheelThickness;
        private int _horsePower;
        private double _tankSize;
        private double _currentOil;
        private string _fuelType;
        private double _wingLength;

        public override double DriveTime { get { return _driveTime; } set { if (value > 0) _driveTime = value; } }
        public override double DrivePath { get { return _drivePath; } set { if (value > 0) _drivePath = value; } }
        public double WheelThickness { get { return _wheelThickness; } set { if (value > 0) _wheelThickness = value; } }
        public int HorsePower { get { return _horsePower; } set { if (value > 0) _horsePower = value; } }
        public double TankSize { get { return _tankSize; } set { if (value > 0) _tankSize = value; } }
        public double CurrentOil { get { return _currentOil; } set { if (value > 0 || value <= TankSize) _currentOil = value; } }
        public string FuelType { get { return _fuelType; } set { if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) _fuelType = value; } }
        public double WingLength { get { return _wingLength; } set { if (value > 0) _wingLength = value; } }

        public Plane(int winglength, double wheelthickness, int horsepower, double tanksize, double currentoil, string fueltype, double drivetime, double drivepath)
        {
            WingLength = winglength;
            WheelThickness = wheelthickness;
            HorsePower = horsepower;
            TankSize = tanksize;
            CurrentOil = currentoil;
            FuelType = fueltype;
            DriveTime = drivetime;
            DrivePath = drivepath;
        }
        public double LeftOilAmount()
        {
            throw new NotImplementedException();
        }
    }
}
