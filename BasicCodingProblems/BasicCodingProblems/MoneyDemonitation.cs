namespace BasicCodingProblems
{
    internal class MoneyDemonitation
    {
        public void Demonitation(long Money)
        {
            while (Money > 0)
            {
                if(Money >= 500)
                {
                    Console.WriteLine($"There are {Money / 500} - 500 notes");
                    Money %= 500;
                }
                else if(Money >= 200)
                {
                    Console.WriteLine($"There are {Money / 200} - 200 notes");
                    Money %= 200;
                }
                else if (Money >= 100)
                {
                    Console.WriteLine($"There are {Money / 100} - 100 notes");
                    Money %= 100;
                }
                else if (Money >= 50)
                {
                    Console.WriteLine($"There are {Money / 50} - 50 notes");
                    Money %= 50;
                }
                else if (Money >= 20)
                {
                    Console.WriteLine($"There are {Money / 20} - 20 notes");
                    Money %= 20;
                }
                else if (Money >= 10)
                {
                    Console.WriteLine($"There are {Money / 10} - 10 notes");
                    Money %= 10;
                }
                else if (Money >= 5)
                {
                    Console.WriteLine($"There are {Money / 5} - 5 notes");
                    Money %= 5;
                }
                else if (Money >= 2)
                {
                    Console.WriteLine($"There are {Money / 2} - 2 notes");
                    Money %= 2;
                }
                else if (Money >= 1)
                {
                    Console.WriteLine($"There are {Money / 1} - 1 notes");
                    Money %= 1;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Money to Demonitation : ");
            long Money = Convert.ToInt32(Console.ReadLine());

            new MoneyDemonitation().Demonitation(Money);
        }
    }
}
