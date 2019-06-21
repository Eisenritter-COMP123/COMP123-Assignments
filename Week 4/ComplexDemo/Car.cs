using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexDemo
{
    class Car
    {
        bool Drivable { get; set; }
        double TankCap { get; set; }
        double MaxSpeed { get;set }

        public Car(bool drive, double Tank, double Speed)
        {
            Drivable = drive;
            TankCap = Tank;
            MaxSpeed = Speed;
        }

        public static void ChangeSpeed()
        {
            Console.WriteLine("What the speed you want to set the car to?");
            double speed = Convert.ToInt32(Console.ReadLine());
            Car.
        }
    }
}
