namespace Functions
{
    internal class TriangleNumberPattern
    {
        public static string NumberPattern(byte Rows)
        {
            string str = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0, k = 1; j < i; j++, k++)
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

            string str = NumberPattern(Rows);

            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
