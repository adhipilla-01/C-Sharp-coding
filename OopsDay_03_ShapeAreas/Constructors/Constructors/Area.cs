namespace Constructors
{
    internal class Area
    {
        double Width;
        double Length;
        double Radius;
        const double Pi = 3.14;

        public Area()
        {
            Width = 0;
            Length = 0;
            Radius = 0;
        }
        public Area(double Width, double Length)
        {
            this.Width = Width;
            this.Length = Length;                
        }

        public Area(double Radius)
        {
            this.Radius = Radius;
        }

        public double GetAreaOfCircle()
        {
            return Pi * Radius * Radius;
        }

        public double GetAreaOfRectangle()
        {
            return Length * Width;
        }


        public static void Main()
        {
            Console.Write("Enter width of rectangle : ");
            double Width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter length of rectangle : ");
            double Length = Convert.ToDouble(Console.ReadLine());
            Area Rectangle = new Area(Width, Length);

            Console.Write("Enter Radius of Circle : ");
            double Radius = Convert.ToDouble(Console.ReadLine());
            Area Circle = new Area(Radius);
            Area Circle1 = new Area();
            Console.WriteLine("Area of Rectangle : " + Rectangle.GetAreaOfRectangle());
            Console.WriteLine("Area of Circle : " +  Circle.GetAreaOfCircle());
            Console.WriteLine("Area of Circle : " + Circle1.GetAreaOfCircle());

            Console.ReadKey();
        }
    }
}
