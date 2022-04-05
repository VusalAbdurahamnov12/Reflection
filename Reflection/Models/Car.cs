using Reflection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection.Models
{
    public class Car : Vehicle, ITransmission, IWheel, IEngine
    {
        private double _driveTime;
        private double _drivePath;
        private string _transmissionKind;
        private double _wheelThickness;
        private int _horsePower;
        private double _tankSize;
        private double _currentOil;
        private string _fuelType;
        private int _doorCount;
        private string _vinCode;
        public override double DriveTime { get => _driveTime;  set { if (value > 0) _driveTime = value; } }
        public override double DrivePath { get => _drivePath;  set { if (value > 0) _drivePath = value; } }
        public string TransmissionKind { get => _transmissionKind;  set { if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) _transmissionKind = value; } }
        public double WheelThickness { get => _wheelThickness;  set { if (value > 0) _wheelThickness = value; } }
        public int HorsePower { get => _horsePower;  set { if (value > 0) _horsePower = value; } }
        public double TankSize { get => _tankSize;  set { if (value > 0) _tankSize = value; } }
        public double CurrentOil { get => _currentOil;  set { if (value > 0 && value <= TankSize) _currentOil = value; } }
        public string FuelType { get => _fuelType;  set { if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) _fuelType = value; } }
        public int DoorCount { get => _doorCount;  set { if (value > 0 || value <= 10) _doorCount = value; } }
        public string VinCode { get => _vinCode;  set { if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) _vinCode = value; } }

        public Car(int doorcount, string vincode, string transmissionkind, double wheelthickness, int horsepower, double tanksize, double currentoil, string fueltype, double drivetime, double drivepath)
        {
            DoorCount = doorcount;
            VinCode = vincode;
            TransmissionKind = transmissionkind;
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
            return TankSize - CurrentOil;
        }
    }
}
