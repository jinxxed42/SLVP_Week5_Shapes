namespace SLVP_Week5_Shapes
{
    internal class Triangle : Shape
    {

        // Using the base constructor
        public Triangle(int width, int height) : base(width, height)
        {

        }

        public double CalcArea()
        {
            return (double)_width * _height / 2;
        }

    }
}
