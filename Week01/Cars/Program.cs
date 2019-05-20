using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the Car Class
            Car car1 = new Car(2019,"Honda","CRV",5799.99);
            Car car2 = new Car(2019, "Lambourghini", "Mucielago", 109799.99, true);
            Car car3 = new Car(2010, "Toyota", "Corolla", 799.99, false);
            //diplay the object
            Console.WriteLine(car1);
            Console.WriteLine(car2);
            Console.WriteLine(car3);
        }
    }
}
