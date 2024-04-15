namespace BasicCodingProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of sides : ");
            int sides = Convert.ToInt32(Console.ReadLine());

            string shape;
            if (sides >= 0)
            {
                switch (sides)
                {
                    case 0:
                        shape = "Dot"; break;
                    case 1:
                        shape = "Single Line"; break;
                    case 2:
                        shape = "Intersecting Or Parallel Line"; break;
                    case 3:
                        shape = "Triangle"; break;
                    case 4:
                        shape = "Quadrilateral"; break;
                    case 5:
                        shape = "Pentagon"; break;
                    case 6:
                        shape = "Hexagon"; break;
                    case 7:
                        shape = "Heptagon / Septagon"; break;
                    case 8:
                        shape = "Octagon"; break;
                    case 9:
                        shape = "Nonogon"; break;
                    default:
                        shape = "Polygon with more than 10 sides"; break;
                }
                Console.WriteLine("\n" + shape);
            }
            Console.ReadKey();
        }
    }
}
