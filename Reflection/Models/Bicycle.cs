using Reflection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection.Models
{
    public class Bicycle : Vehicle, IWheel, ITransmission
    {
        private string _pedalKind;
        private double _driveTime;
        private double _drivePath;
        private string _transmissionKind;
        private  double _wheelThickness;
        public  string PedalKind;
        public double WheelThickness { 
            get => _wheelThickness;

            set 
            {
                if (value > 0) _wheelThickness = value;
            } 
        }
        public string TransmissionKind { 
            get => _transmissionKind;
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) _transmissionKind = value;
            }
        }
        public override double DriveTime { 
            get =>_driveTime;
            set
            {
                if (value > 0) _driveTime = value;
            } }
        public override double DrivePath 
        {
            get =>_drivePath;
            set
            {
                if (value > 0) _drivePath = value;
            }
        }
        public Bicycle(string pedalKind, double wheelThickness, string transmissionKind, double driveTime, double drivePath)
        {
            PedalKind = pedalKind;
            WheelThickness = wheelThickness;
            TransmissionKind = transmissionKind;
            DriveTime = driveTime;
            DrivePath = drivePath;
        }
    }
}
