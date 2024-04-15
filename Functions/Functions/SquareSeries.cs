using System.Text;

namespace Functions
{
    internal class SquareSeries
    {
        public static StringBuilder Series(int num)
        {
            int i = 1;
            StringBuilder sb = new StringBuilder(1000);
            while (i > 0)
            {
                int len = sb.Length;
                
                if ((i * i) > num)
                {
                    Console.WriteLine("Length = " + len);
                    sb.Replace(",", " ", len - 2, 1);
                    return sb;
                }
                if (i % 2 == 0)
                {
                    sb.Append(-i * i + ", ");
                }
                if (i % 2 == 1)
                {
                    sb.Append(i * i + ", ");
                }
                i++;
            }
            return sb;
        }
        public static void Main()
        {
            Console.Write("Enter upper square bound : ");
            int num = Convert.ToInt32(Console.ReadLine());

            StringBuilder str = Series(num);
            Console.WriteLine("\nSquare series alternate signs : " + str);

            Console.ReadLine();
        }
    }
}
