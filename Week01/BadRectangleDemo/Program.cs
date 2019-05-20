using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadRectangleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize a BadRectangle object
            BadRectangle badRectangle = new BadRectangle();
            //set the object length and width to 10 and 8
            badRectangle.length = 10;
            badRectangle.width = 8;

            // invoke the DescribeBadRectangle method
            DescribeBadRectangle(badRectangle);

            // invoke the CalculateAndDisplayArea method
            CalculateAndDisplayArea(badRectangle);

            // invoke CreateBadRectangle method
            BadRectangle george = CreateBadRectangle(5, 8);
            DescribeBadRectangle(george);
            CalculateAndDisplayArea(george);
            

        }
        static void DescribeBadRectangle(BadRectangle rect)
        {
            Console.WriteLine($"Length:{rect.length} Width:{rect.width}");
        }
        static void CalculateAndDisplayArea(BadRectangle rect)
        {
            Console.WriteLine($"The are of the rectangle is:{rect.length*rect.width}");
        }
        static BadRectangle CreateBadRectangle(int length, int width)
        {
            BadRectangle rect = new BadRectangle();
            rect.length = length;
            rect.width = width;
            return rect; 
        }
    }

    class BadRectangle
    {
        public int length;
        public int width;
    }
}
