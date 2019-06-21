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
        double MaxSpeed { get; set; }
        double MaxAcceleration { get; set; }
        double Suspension { get; set; }
        double Break { get; set; }
        bool Nitros { get; set; }
        string Brand { get; set; }
        string Make { get; set; }
        int Year { get; set; }
        bool Tuning { get; set; }
        double FuelEfficiency { get; set; }


        public Car(
            double tank, 
            double speed, 
            double accel, 
            double sus, 
            double breaker, 
            bool nitros,
            double feficy,
            int year, 
            string brand ="", 
            string make="", 
            bool tuning =false,
            bool drive = false)
            
        {
            Drivable = drive;
            TankCap = tank;
            MaxSpeed = speed;
            MaxAcceleration = accel;
            Suspension = sus;
            Break = breaker;
            Nitros = nitros;
            Brand = brand;
            Make = make;
            Year = year;
            Tuning = tuning;
            FuelEfficiency = feficy;
        }

        public override string ToString()
        {
            return Car;
        }
    }
}
