using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class BasicProgrammings
    {
        public void LeapYear()
        {
            Console.Clear();
            Console.Write("\nEnter year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine($"\nThe Year {year} is Leap Year having 366 days");
            }
            else Console.WriteLine($"\nThe Year {year} is Normal Year having 365 Days");                
        }
        public void Fibanocci()
        {
            Console.Clear();
            Console.Write("\nEnter number of series : ");
            int terms = Convert.ToInt32(Console.ReadLine());
            int f1 = 0, f2 = 1, f3;
            for (int i = 0; i < terms; i++)
            {
                Console.WriteLine(f1);
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
        }
        public void MoneyDemonitation()
        {
            Console.Clear();
            Console.Write("\nEnter Amount to Demonistate : ");
            int amount = Convert.ToInt32(Console.ReadLine());

            int[] money = {500, 200, 100, 50, 20, 10, 5, 2, 1};
            
            foreach (int i in money)
            {
                if(amount >= i)
                {
                    int count = amount / i;
                    amount = amount % i;
                    Console.WriteLine($"\n{count} Notes/Coins of {i}");
                }
            }
        }
        public void NormalDimond()
        {
            Console.Clear();
            Console.Write("\nEnter Number of Rows (Odd only): ");
            byte rows = Convert.ToByte(Console.ReadLine());

            for(int i = 1; i <= rows; i += 2)
            {
                int space = (rows - i) / 2;
                for(int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0;j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = rows - 2; i >= 1; i -= 2)
            {
                int space = (rows - i) / 2;
                for(int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                for( int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        public void HollowDimond()
        {
            Console.Clear();
            Console.Write("\nEnter number of rows : ");
            byte rows = Convert.ToByte(Console.ReadLine());

            for (int i = 1; i <= rows; i += 2)
            {
                int space = (rows - i) / 2;
                for (int j = 0; j <= space; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    if (j == 0 || j == i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            //printing lower diamond
            for(int i = rows - 2; i >= 1; i -= 2)
            {
                int space = (rows - i) / 2 + 1;
                for( int j = 0; j < space;j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < i; j++)
                {
                    if (j == 0 || j == i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
