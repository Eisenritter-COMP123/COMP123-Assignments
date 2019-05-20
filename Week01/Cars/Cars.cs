using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Car
    {
        int year;
        string manuf;
        string model;
        bool drivable;
        double price;

        public Car(int year, string manufacturer, string model, double price, bool isDrivable = true)
        {
            this.year = year;
            this.manuf = manufacturer;
            this.model = model;
            this.price = price;
            this.drivable = isDrivable;
        }

        public override string ToString()
        {
            return $"{year}{manuf,15}{model,15}{price,15:C}{(drivable?"Drivable":"No Drivable"),15}";
        }

    }
}
