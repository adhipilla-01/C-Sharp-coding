namespace Functions
{
    internal class NumberTriangleBothSides
    {
        public static string GetPattern(byte Rows)
        {
            string str = "";
            for (int i = Rows, k = 1; i > 0; i--, k++)
            {
                for (int j = 0, m = k; j <= Rows; j++)
                {
                    if (j >= i)
                    {
                        str = str + m + " ";
                        m--;
                    }
                    else
                    {
                        str = str + "  ";
                    }
                }

                for (int j = 0, n = 1; j <= Rows - i; j++, n++)
                {
                    str = str + n + " ";
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
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
