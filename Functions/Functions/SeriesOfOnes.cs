namespace Functions
{
    internal class SeriesOfOnes
    {
        public static string GetSeries(byte series)
        {
            string str = "\n";
            long x = 1;
            long Sum = 0;
            for (int i = 0; i < series; i++)
            {
                Sum += x;
                str = str + x + " + ";
                x = x * 10 + 1;                        
            }
            Console.WriteLine(Sum);
            str = str + "\n\nThe Sum of series is " + Sum;

            return str;
        }
        public static void Main()
        {
            Console.Write("Enter how many series you want : ");
            byte series = Convert.ToByte(Console.ReadLine());

            string str = GetSeries(series);
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
