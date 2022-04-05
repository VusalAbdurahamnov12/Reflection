using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection.Models
{
    public static class Extension
    {
        public static void ShowInfo(this Vehicle vehicle)
        {
            Console.Clear();
            foreach (var item in vehicle.GetType().GetProperties())
            {
                Console.WriteLine($"{item.Name} - {item.GetValue(vehicle)}");
            }
            Console.WriteLine("DriveSpeed - " + vehicle.AverageSpeed());
        }
    }
}
