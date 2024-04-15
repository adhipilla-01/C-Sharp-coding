namespace OopsProject
{
    abstract class Figure
    {
        public const float pi = 3.14f;
        public double Radius;
        public double Height;
        public double Width;

        public abstract double GetArea();
    }

    class Cone : Figure
    {
        public Cone(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return pi * Radius * (Radius + Math.Sqrt((Height * Height) + (Radius * Radius)));
        }
    }

    class Circle : Figure
    {
        public Circle(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return pi * Radius * Radius;
        }
    }

    class Triangle : Figure
    {
        public Triangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return 0.5 * Width * Height;
        }
    }

    class Rectangle : Figure
    {
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    internal class AreaOfShape
    {     
        public static void Main()
        {
            Cone cone = new Cone(5.5, 10);
            double ConeArea = cone.GetArea();

            Circle circle = new Circle(10, 10);
            double CircleArea = circle.GetArea();

            Triangle triangle = new Triangle(10, 10);
            double TriangleArea = triangle.GetArea();

            Rectangle rectangle = new Rectangle(10, 10);
            double RectangleArea = rectangle.GetArea();

            Console.WriteLine($"\nArea of Cone      =  {ConeArea}\nArea of Circle    =  {CircleArea}\nArea of Triangle  =  {TriangleArea}\nArea of Rectangle =  {RectangleArea}");

            Console.ReadLine();
        }
    }
}
