using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDay_03_ShapeAreas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Length of Rectangle : ");
            double Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Width of Rectangle  : ");
            double Width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Area of Circle      : ");
            double Radius = Convert.ToDouble(Console.ReadLine());

            Area AreaOfRectangle = new Area(Width, Length);
            Area AreaOfCircle = new Area(Radius);
            double RectangleArea = AreaOfRectangle.RectangleArea();
            double CircleArea = AreaOfCircle.CircleArea();
            Console.WriteLine("\nArea of the Shapes According to given data (parameters) : ");
            Console.Write($"\nArea of Rectangle is {RectangleArea}");
            Console.Write($"\nArea of Circle is {CircleArea}\n\n");
        }
    }
}
