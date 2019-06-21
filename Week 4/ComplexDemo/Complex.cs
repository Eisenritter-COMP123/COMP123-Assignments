using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexDemo
{
    class Complex
    {
        public int Real { get;}
        public int Imaginary { get;}
        public double Argument
        {
            get
            {
                return Math.Atan(Real/Imaginary);
            }
        }
        public double Modulus
        {
            get
            {
                return Math.Pow(Math.Pow(Real, 2) * Math.Pow(Imaginary, 2), 0.5);
            }
        }


        public Complex(int real=0, int imaginary=0)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;
            return new Complex(real, imaginary);
        }

        public static Complex operator -(Complex lhs, Complex rhs)
        {
            int real = lhs.Real - rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;
            return new Complex(real, imaginary);
        }

        public static Complex operator -(Complex arg)
        {
            return new Complex(-arg.Real, -arg.Imaginary);
        }

        public static bool operator == (Complex lhs, Complex rhs)
        {
            return lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary;
        }

        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return !(lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real},{Imaginary}i";
        }
    }
}
