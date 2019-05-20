using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rationale
{
    class Rational
    {
        public int den{get;private set;}
        public int num { get; private set; }
        int sign=1;

        public Rational(int numerator = 0, int denominator = 1)
        {
            this.den = denominator;
            this.num = numerator;
            GCD(this.num, this.den);
        }


        public void IncreaseBy(Rational other)
        {
            this.num = this.num * other.den + other.num * this.den;
            this.den *= other.den;
            GCD(this.num, this.den);
        }

        public void DecreaseBy(Rational other)
        {
            this.num = this.num * other.den - other.num * this.den;
            this.den *= other.den;
            GCD(this.num, this.den);
        }
        
        private void GCD (int num, int den)
        {
            //int count=1;
            int gcd = 1;
            /******************************************************************************
             * This is the old GCD method, finding the GCD by incremental trial and error *
             ******************************************************************************
             * 
             *             while (count <= Math.Abs(num) && count <= Math.Abs(den))
            {
                if (num % count == 0 && den % count == 0)
                {
                    gcd = count;
                }
                count++;
            }
             ******************************************************************************/

            /******************************************************************************
            //          GCD calculated with the Euclidean Algorithm                      //
            ******************************************************************************/

            int tempNum = Math.Abs(num), tempDen =Math.Abs (den) ;
            while (tempDen != 0 && tempNum != 0) {
    if (tempNum > tempDen)
    {
        tempNum %= tempDen;
    }
    else {
        tempDen %= tempNum;
    }

}
            gcd = (tempDen > 0) ? tempDen : tempNum;

            /******************************************************************************
            //          Find Positive or Negative                                        //
            ******************************************************************************/
            if (num < 0)
            {
                sign *= -1;
            }
            if (den < 0)
            {
                sign *= -1;
            }

            this.num = Math.Abs(this.num)/gcd*sign;
            this.den = Math.Abs(this.den) / gcd;
}



public override string ToString()
{
if (this.den == 1)
{
    return $"({num})";
}
else if (this.num == 0)
{
    return "(0)";
}
return $"({num}/{den})";
}
}
}
