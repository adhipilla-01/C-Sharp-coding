namespace Functions
{
    internal class AlphaNumericTriangleBothSides
    {
        public static string GetPattern(byte Rows)
        {
            string str = "";
            char letter = 'A';
            for (int i = Rows, k = 1; i > 0 ; i--, letter++, k++)
            {
                for (int j = 0; j <= Rows; j++)
                {
                    if (j >= i)
                    {
                        str = str + letter + " ";
                    }
                    else
                    {
                        str = str + "  ";
                    }
                }
                for (int j = 0; j <= Rows - i; j++)
                {
                    str = str + k + " ";
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

            Console.ReadKey();
        }
    }
}
