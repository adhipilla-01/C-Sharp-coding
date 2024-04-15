namespace Functions
{
    internal class AlphabetsPattern
    {
        public static string GetPattern(byte Rows)
        {
            string str = "";
            char letter = 'A';
            for (int i = 0; i <= Rows; i++, letter++)
            {
                for (int j = 0; j <= i; j++)
                {
                    str = str + letter + " ";
                }
                str = str + "\n";
            }
            return str;
        }

        public static void Main()
        {
            Console.Write("Enter number of rows: ");
            byte Rows = Convert.ToByte(Console.ReadLine());

            string str = GetPattern(Rows);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
