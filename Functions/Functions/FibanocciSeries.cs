namespace Functions
{
    internal class FibanocciSeries
    {
        public static void Fibanocci(byte series)
        {
            int f1, f2 = 0, f3 = 1;

            for (int i = 0; i < series; i++)
            {
                f1 = f2;
                Console.Write(f2 + " ");
                f2 = f1 + f3;
                f3 = f1;
            }
        }

        public static void Main()
        {
            Console.Write("Enter a number(series) : ");
            byte series = Convert.ToByte(Console.ReadLine());
            Console.Write("\nFibanocci series : ");
            Fibanocci(series);
            Console.ReadLine();
        }
    }
}
