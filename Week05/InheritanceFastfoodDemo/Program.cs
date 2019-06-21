using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFastfoodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Supervisor supervisor = new Supervisor("Henry");
            Server server = new Server("George");
            Manager manager = new Manager("Narendra");

            Console.WriteLine(manager);
            Console.WriteLine(server);
            Console.WriteLine(supervisor);
        }
    }
}
