using Reflection.Models;
using System;

namespace Reflection
{
    internal class Program
    {
        private static double _tankSize;
        static void Main(string[] args)
        {
            
            int choice = 0;
            do
            {
                Console.WriteLine("[0]-Cixis\n[1]-Bicycle\n[2]-Car\n[3]-Plane");
                Console.WriteLine("Secim edin:");
                choice=Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        StartBcycel();
                        break;
                    case 2:
                        StartCar();
                        break;
                    case 3:
                        StartPlane();
                        break;
                    default:
                        break;
                }
            } while (choice != 0);
        }
        static void PedalKind(out string pedalKind)
        {
        Start:
            try
            {
                Console.Write("Pedali daxil edin: ");
                pedalKind = Console.ReadLine();
                if (string.IsNullOrEmpty(pedalKind) || string.IsNullOrWhiteSpace(pedalKind)) throw new Exception("Pedalin novu vacibdir");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void WheelTickness(out double wheelTickness)
        {
        Start:
            try
            {
                Console.Write("Tekerin qalinligini daxil edin: ");
                wheelTickness = Convert.ToDouble(Console.ReadLine());
                if (wheelTickness <= 0) throw new Exception("Tekerin qalinligini bos ola bilmez");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void TransmissionKind(out string transmissionKind)
        {
        TransmissionKind:
            try
            {
                Console.Write("Transmison daxil edin: ");
                transmissionKind = Console.ReadLine();
                if (string.IsNullOrEmpty(transmissionKind) || string.IsNullOrWhiteSpace(transmissionKind)) throw new Exception("Transmison bos ola bilmez");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto TransmissionKind;
            }

        }
        static void DriveTime(out double driveTime)
        {
        DriveTime:
            try
            {
                Console.Write("zamani daxil edin : ");
                driveTime = Convert.ToDouble(Console.ReadLine());
                if (driveTime <= 0) throw new Exception("Zamani dogru daxil edin");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto DriveTime;
            }

        }
        static void DrivePath(out double drivePath)
        {
        DrivePath:
            try
            {
                Console.Write("yolu daxil edin: ");
                drivePath = Convert.ToDouble(Console.ReadLine());
                if (drivePath <= 0) throw new Exception("Yolu dogru daxil edin");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto DrivePath;
            }
        }
        static void DoorCount(out int doorCount)
        {
        DoorCount:
            try
            {
                Console.Write("Qapini sayini dail x: ");
                doorCount = Convert.ToInt32(Console.ReadLine());
                if (doorCount <= 0 || doorCount > 10) throw new Exception("Dorgu daxil edin");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto DoorCount;
            }
        }
        static void VinCode(out string vinCode)
        {
        VinCode:
            try
            {
                Console.Write("Vin kodu daxil edin : ");
                vinCode = Console.ReadLine();
                if (string.IsNullOrEmpty(vinCode) || string.IsNullOrWhiteSpace(vinCode)) throw new Exception("bos ola bilmez");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto VinCode;
            }

        }
        static void HorsePower(out int horsePower)
        {
        HorsePower:
            try
            {
                Console.Write("at gucunun daxil edin: ");
                horsePower = Convert.ToInt32(Console.ReadLine());
                if (horsePower <= 0) throw new Exception("Bos ola bilmez");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto HorsePower;
            }
        }
        static void TankSize(out double tankSize)
        {
        TankSize:
            
            try
            {
                Console.Write("yagi daxil edin: ");
                tankSize = Convert.ToDouble(Console.ReadLine());
                _tankSize=tankSize;
                if (tankSize <= 0) throw new Exception("Dogru daxil edin");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto TankSize;
            }
        }
        static void SetCurrentOil(out double currentOil)
        {
        Start:
            try
            {
                Console.Write("Cari yağ miqdarını daxil edin: ");
                currentOil = Convert.ToDouble(Console.ReadLine());
                if (currentOil < 0 || _tankSize < currentOil)throw new Exception("Yag tutumundan cox ola bilmez");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void FuelType(out string fuelType)
        {
        FuelType:
            try
            {
                Console.Write("Benzinin adini daxil edin: ");
                fuelType = Console.ReadLine();
                if (string.IsNullOrEmpty(fuelType) || string.IsNullOrWhiteSpace(fuelType)) throw new Exception("bos ola bilmez.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto FuelType;
            }
        }
        static void WingLength(out int wingLength)
        {
           WingLength:
            try
            {
                Console.Write("qanadin uzunlugunu daxil edin: ");
                wingLength = Convert.ToInt32(Console.ReadLine());
                if (wingLength <= 0 || wingLength > 120) throw new Exception("0-120 intervali olmalidir");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto WingLength;
            }
        }
        static void StartBcycel()
        {
            Console.Clear();
            PedalKind(out string pedalKind);
            WheelTickness(out double wheelTicknessBicycle);
            TransmissionKind(out string transmissionKind);
            DriveTime(out double driveTimeBicycle);
            DrivePath(out double drivePathBicycle);
            Bicycle bicycle = new Bicycle(pedalKind, wheelTicknessBicycle, transmissionKind, driveTimeBicycle, drivePathBicycle);
            bicycle.ShowInfo();
        }
        static void StartCar()
        {
            Console.Clear();
            DoorCount(out int doorCount);
            VinCode(out string vinCode);
            TransmissionKind(out string transmissionKindCar);
            WheelTickness(out double wheelTicknessCar);
            HorsePower(out int horsePowerCar);
            TankSize(out double tankSizeCar);
            SetCurrentOil(out double currentOilCar);
            FuelType(out string oilTypeCar);
            DriveTime(out double driveTimeCar);
            DrivePath(out double drivePathCar);
            Car car = new Car(doorCount, vinCode, transmissionKindCar, wheelTicknessCar, horsePowerCar, tankSizeCar, currentOilCar, oilTypeCar, driveTimeCar, drivePathCar);
            car.ShowInfo();
        }
        static void StartPlane()
        {
            Console.Clear();
            WingLength(out int wingLength);
            WheelTickness(out double wheelTicknessPlane);
            HorsePower(out int horsePowerPlane);
            TankSize(out double tankSizePlane);
            SetCurrentOil(out double currentOilPlane);
            FuelType(out string oilTypePlane);
            DriveTime(out double driveTimePlane);
            DrivePath(out double drivePathPlane);
            Plane plane = new Plane(wingLength, wheelTicknessPlane, horsePowerPlane, tankSizePlane, currentOilPlane, oilTypePlane, driveTimePlane, drivePathPlane);
            plane.ShowInfo();
        }   
    }
}
