using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_Week5_Shapes
{
    internal class Triangle : Shape
    {

        public Triangle(int width, int height) : base(width, height)
        {

        }

        public double CalcArea()
        {
            return (double)_width * _height / 2;
        }

    }
}
