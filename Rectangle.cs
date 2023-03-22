using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_Week5_Shapes
{
    internal class Rectangle : Shape
    {
        public Rectangle(int width, int height) : base(width, height) 
        {

        }

        public int CalcArea()
        {
            return _width * _height;
        }

    }
}
