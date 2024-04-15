namespace Constructors
{
    internal class Sum
    {
        int Num1;
        int Num2;
        public Sum(int Num1, int Num2)
        {
            this.Num1 = Num1;
            this.Num2 = Num2;
        }

        public int GetSum()
        {
            int Sum = Num1 + Num2;
            return Sum;
        }

        public static void Main()
        {
            Console.Write("Enter first number : ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            Sum sum = new Sum(Num1, Num2);
            int Sum = sum.GetSum();
            Console.WriteLine($"\nThe sum of {Num1} and {Num2} is {Sum}");

            Console.ReadKey();
        }
    }
}
