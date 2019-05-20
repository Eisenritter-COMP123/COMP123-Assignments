using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rationale
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational();
            Rational r2 = new Rational(1);
            Rational r3 = new Rational(1,2);
            

            Console.WriteLine($"First Fraction: {r1}");
            Console.WriteLine($"Second Fraction:  {r2}");
            Console.WriteLine($"Third Fraction:  {r3}");

            Rational frac = new Rational(123, -432);
            Console.Write($"{frac} + {r2} = " );
            frac.IncreaseBy(r2);
            Console.WriteLine($"{frac}, addend is {r2}");

            Console.Write($"{ frac} + {r3} = ");
            frac.IncreaseBy(r3);
            Console.WriteLine($"{frac}, addend is {r3}");

            Console.Write($"{ frac} - {r1} = ");
            frac.DecreaseBy(r1);
            Console.WriteLine($"{frac}, subtrahend is {r1}");

            Console.Write($"{ frac} - {r2} = ");
            frac.DecreaseBy(r2);
            Console.WriteLine($"{frac}, subtrahend is {r2}");
        }
    }
}
