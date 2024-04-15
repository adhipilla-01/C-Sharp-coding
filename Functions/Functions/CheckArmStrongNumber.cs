namespace Functions
{
    internal class CheckArmStrongNumber
    {
        public static bool IsArmstrong(int num)
        {
            byte cnt = 0;
            for (int i = num; i > 0; i /= 10, cnt++);
            double sum = 0;
            for (int i = num; i > 0; i /= 10)
            {
                sum += Math.Pow(i % 10, cnt);
            }
            if (sum == num)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        public static void Main()
        {
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (IsArmstrong(num))
            {
                Console.WriteLine($"\nThe number {num} is a Armstrong number ");
            }
            else
            {
                Console.WriteLine($"\nThe number {num} is not a Armstrong number ");
            }
            Console.ReadLine();
        }
    }
}
