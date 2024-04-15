namespace Functions
{
    internal class ReverseNumber
    {
        public static int NumberReverse(int num)
        {
            int RevNum = 0;
            while (num > 0)
            {
                RevNum = RevNum  * 10 + num % 10;
                num /= 10;
            }
            return RevNum;
        }

        public static void Main()
        {
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int RevNum = NumberReverse(num);
            Console.WriteLine($"\nNumber before reverse : {num}\nNumber after  reverse : {RevNum}");
            Console.ReadLine();
        }
    }
}
