namespace Functions
{
    internal class TopRightTrianglePattern
    {
        public static string GetPattern(byte Rows)
        {
            string str = "";
            for (int i = Rows; i >= 0; i--)
            {
                for (int j = 0; j <= Rows; j++)
                {
                    if (j >= Rows - i)
                    {
                        str = str + "* ";
                    }
                    else
                    {
                        str = str + "  ";
                    }

                }
                str = str + "\n";
            }

            return str;
        }

        public static void Main()
        {
            Console.Write("Enter number of rows : ");
            byte Rows = Convert.ToByte(Console.ReadLine());

            string str = GetPattern(Rows);
            Console.WriteLine("\n" + str);

            Console.ReadKey();
        }
    }
}
