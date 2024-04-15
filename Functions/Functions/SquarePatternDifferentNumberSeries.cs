namespace Functions
{
    internal class SquarePatternDifferentNumberSeries
    {
        public static void SquarePattern(byte Rows)
        {
            int[,] Array = new int[Rows, Rows];
            for (int i = 0, k = 1; i < Rows; i++)
            {
                for (int j = 0, m = 1; j < Rows; j++)
                {
                    if (i % 2 == 1)
                    {
                        Array[j, i] = m;
                        m++;
                    }
                    if (i % 2 == 0)
                    {
                        Array[j, i] = k;                        
                    }
                }
                if (i % 2 == 0)k++;
            }

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    Console.Write(Array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Main()
        {
            Console.Write("Enter number of Rows : ");
            byte Rows = Convert.ToByte(Console.ReadLine());

            SquarePattern(Rows);
            Console.ReadKey();
        }
    }
}
