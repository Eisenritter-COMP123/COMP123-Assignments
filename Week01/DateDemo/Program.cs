using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the Date Class
            Date d1 = new Date(2019, 5, 10);
            Date d2 = new Date(5, 21, 36);

            Console.WriteLine(d1);
            //method 1 test
            Console.WriteLine("Adding 15 days to the date");
            d1.Add(15);
            Console.WriteLine(d1);
            //method 2 test
            d1.Add(5, 37);
            Console.WriteLine("Adding 5 months, 2 days to the date");
            Console.WriteLine(d1);
            //method 3 test
            Console.WriteLine($"Adding {d2} to the date");
            d1.Add(d2);
            Console.WriteLine(d1);
        }
    }
}
