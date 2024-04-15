using System.Text;

namespace Functions
{
    internal class SquarePattern
    {
        public static string Pattern(byte Rows)
        {
            string str = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    str = str + "* ";
                }
                str = str + "\n";
            }
            return str;
        }

        public static StringBuilder Pattern1(byte Rows)
        {
            StringBuilder str = new StringBuilder(1000);
            
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    str.Append("* ");
                }
                str.Append("\n");
            }
            return str;
        }
        public static void Main()
        {
            Console.Write("Enter number of rows : ");
            byte Rows = Convert.ToByte(Console.ReadLine());

            string str = Pattern(Rows);
            StringBuilder str1 = Pattern1(Rows);

            Console.WriteLine("\nSquare Pattern : \n" + str);
            Console.WriteLine("Triangle Pattern : \n" + str1);
            Console.ReadLine();
        }
    }
}
