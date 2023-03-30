namespace SLVP_Week5_Shapes
{
    // Making it abstract since we won't instantiate this class, but only it's subclasses.
    internal abstract class Shape
    {
        protected int _width;
        protected int _height;

        public Shape(int width, int height)
        {
            _width = width;
            _height = height;
        }
    }
}
