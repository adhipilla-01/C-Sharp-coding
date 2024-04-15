namespace Functions
{
    internal class SquarePatternNumberIteration
    {
        public static string SquarePattern(byte Rows)
        {
            string str = "";
            for (int i = 0, k = 1; i < Rows; i++, k++)
            {
                for (int j = 0, m = k; j < Rows; j++, m += k)
                {
                    str = str + m + " ";
                }
                str = str + "\n";
            }
            return str;
        }

        public static void Main()
        {
            Console.Write("Enter number of rows : ");
            byte Rows = Convert.ToByte(Console.ReadLine());

            string str = SquarePattern(Rows);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
