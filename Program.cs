using SLVP_Week5_Shapes;

int height = 40;
int width = 60;

Rectangle rec = new Rectangle(width, height);
int recArea = rec.CalcArea();

Triangle tri = new Triangle(width, height);
double triArea = tri.CalcArea();

Console.WriteLine("Input is height: " + height + " and width: " + width + ".");
Console.WriteLine("Area of rectangle is: " + recArea + ".");
Console.WriteLine("Area of triangle is: " + triArea + ".");