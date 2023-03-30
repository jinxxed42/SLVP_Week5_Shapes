using SLVP_Week5_Shapes;

int height = 40;
int width = 60;

Rectangle rectangle = new Rectangle(width, height);
int recArea = rectangle.CalcArea();

Triangle triangle = new Triangle(width, height);
double triArea = triangle.CalcArea();

Console.WriteLine("Input is height: " + height + " and width: " + width + ".");
Console.WriteLine("Area of rectangle is: " + recArea + ".");
Console.WriteLine("Area of triangle is: " + triArea + ".");