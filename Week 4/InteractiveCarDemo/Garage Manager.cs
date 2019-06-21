using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexDemo
{
    class Garage_Manager
    {
        static List<Car> Cars = new List<Car>();
        public void AddCar2Garage(Car car)
        {
            Cars.Add(car);
        }

        public Car SelectCar(Car car)
        {
            foreach (Car auto in Cars)
            {
                (auto.Equals(car)) ? return auto: return null);
            }
        }

        public void RemoveCarFromGarage(Car car)
        {
            foreach (Car auto in Cars)
            {
                (auto.Equals(car)) ? (Cars.Remove(auto):);
            }
        }
    }
