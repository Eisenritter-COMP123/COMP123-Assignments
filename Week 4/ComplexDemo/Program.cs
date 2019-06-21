using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c0 = new Complex(-2, 3);
            Complex c1 = new Complex(-2, 3);
            Complex c2 = new Complex(1, -2);
            Complex c3 = c1 + c2;
            Console.WriteLine("{0} + {1} = {2}", c1, c2, c3);
            Console.WriteLine("{0} - {1} = {2}", c1, c2, c1 - c2);

            Console.WriteLine("{0} in polar form is {1:f2}cis({2:f2})", c3, c3.Modulus, c3.Argument);

            Console.WriteLine("{0} {1} {2}", c0, (c0 == c1) ? "=" : "!=", c1);
            Console.WriteLine("{0} {1} {2}", c0, (c0 == c2) ? "=" : "!=", c2);
        }
    }
}
