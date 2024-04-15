namespace Functions
{
    internal class DigitsSum
    {
        public static int SumOfDigits(int num)
        {
            int sum = 0;
            for (int i = num; i > 0; i /= 10)
            {
                sum += i % 10;
            }
            return sum;
        }

        public static void Main()
        {
            Console.Write("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = SumOfDigits(num);
            Console.WriteLine($"\nSum of digits in given number {num} is {sum}");
            Console.ReadLine();
        }
    }    
}
