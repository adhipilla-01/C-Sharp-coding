namespace Functions
{
    internal class NumberPatternRightSideTriangle
    {
        public static string GetPattern(byte rows)
        {
            string str = "";
            for (int i = 0, k = 1; i < rows; i++)
            {
                for (int j = 0; j <= rows; j++)
                {
                    if (j >= rows - i)
                    {
                        str = str + (k * k) + " ";
                        k++;
                    }
                    else
                    {
                        str = str + "   ";
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
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
