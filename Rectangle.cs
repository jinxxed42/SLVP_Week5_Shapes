namespace SLVP_Week5_Shapes
{
    internal class Rectangle : Shape
    {

        // Using the base constructor
        public Rectangle(int width, int height) : base(width, height) 
        {

        }

        public int CalcArea()
        {
            return _width * _height;
        }

    }
}
