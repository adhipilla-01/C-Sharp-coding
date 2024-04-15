namespace Functions
{
    internal class Factorial
    {
        public static int FindFactorial(int num)
        {
            int Factorial = 1;
            if (num == 1 || num == 0)
            {
                return 1;
            }
            while (num > 1)
            {
                Factorial *= num;
                num--;
            }
            return Factorial;
        }
        public static void Main()
        {
            Console.Write("Enter a number : ");
            byte num = Convert.ToByte(Console.ReadLine());
            int Factorial = FindFactorial(num);
            Console.WriteLine($"\nFactorial of {num} is " + Factorial);
            Console.ReadLine();
        }
    }
}
