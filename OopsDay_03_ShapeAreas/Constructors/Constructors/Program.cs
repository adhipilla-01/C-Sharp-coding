namespace Constructors
{
    internal class Program
    {
        int Sum = 0;
        public Program(params int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Sum += x[i];
            }
        }

        public void DisplaySum()
        {
            Console.WriteLine($"\nThe sum of given numbers is {Sum}");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter how many numbers : ");
            byte Nums = Convert.ToByte(Console.ReadLine());
            int[] Num = new int[Nums];

            for (int i = 0; i < Nums; i++)
            {
                Num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Program Sum = new Program(Num);
            Sum.DisplaySum();
            Console.ReadKey();
        }
    }
}
