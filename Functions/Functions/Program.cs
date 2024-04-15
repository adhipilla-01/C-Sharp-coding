namespace Functions
{
    internal class Program
    {
        public static bool IsPrime(int num)
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num > 0)
            {
                for (int i = 2; i <= num; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("\nEnter a valid number !");
                return;
            }

            Console.ReadKey();
        }
    }
}
