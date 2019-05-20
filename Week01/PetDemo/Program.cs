using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the Date Class
            Pet p1 = new Pet("Lucy", 5, "A golden retriever");
            //method 1 test
            Console.WriteLine(p1);

            p1.setOwner("George");
            Console.WriteLine(p1);

            p1.AddTrick("Flip");
            Console.WriteLine(p1);
        }
    }
}
