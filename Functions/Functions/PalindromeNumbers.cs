namespace Functions
{
    internal class PalindromeNumbers
    {
        public static string PalindromeRange(int Snum, int Enum)
        {
            string str = "";
            for (int i = Snum; i <= Enum; i++)
            {
                if (IsPalindrome(i))
                {
                    str = str + i + " ";
                }
            }
            return str;
        }

        public static bool IsPalindrome(int Num)
        {
            int Rev = 0;
            for (int i = Num; i > 0; i /= 10)
            {
                Rev = Rev * 10 + i % 10;
            }
            if (Rev == Num)return true;
            return false;
        }

        public static void Main()
        {
            Console.Write("Enter starting Number : ");
            int Snum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter ending Number : ");
            int Enum = Convert.ToInt32(Console.ReadLine());

            string str = PalindromeRange(Snum, Enum);
            Console.WriteLine($"\nPalindrome Numbers between {Snum} and {Enum} : \n\n" + str);
            Console.ReadKey();
        }
    }
}
