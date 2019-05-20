using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleDemo
{
    class Rectangle
    {
        //data members
        //more correctly fields
        int length;
        int width;

        //construtor
        //no return type
        public Rectangle(int len, int wid)
        {
            length = len;
            width = wid;
        }
        //the ToString method is called when the object has to be displayed
        public override string ToString()
        {
            return $"Length:{length}, width:{width}";
        }
    }
}
