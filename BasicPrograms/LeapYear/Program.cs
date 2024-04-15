using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            a:
            Console.Clear();
            Console.Write("Enter a option :\n1.Leap Year\n2.Fibanocci Series\n3.Money Demonitation\n4.Normal Dimond\n5.Hollow Dimond : ");
            byte option = Convert.ToByte(Console.ReadLine());

            BasicProgrammings BasicPrograms = new BasicProgrammings();
            if (option == 1) 
            { 
                BasicPrograms.LeapYear();
                Console.Write("\nDo you want to Back to Home [ Y / N] : ");
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'Y' || ch == 'y')
                {
                    goto a;
                }
            }
            else if (option == 2) 
            { 
                BasicPrograms.Fibanocci();
                Console.Write("\nDo you want to Back to Home [ Y / N] : ");
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'Y' || ch == 'y')
                {
                    goto a;
                }
            }
            else if (option == 3) 
            {
                BasicPrograms.MoneyDemonitation();
                Console.Write("\nDo you want to Back to Home [ Y / N] : ");
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'Y' || ch == 'y')
                {
                    goto a;
                }
            }
            else if (option == 4) 
            {
                BasicPrograms.NormalDimond();
                Console.Write("\nDo you want to Back to Home [ Y / N] : ");
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'Y' || ch == 'y')
                {
                    goto a;
                }
            }
            else if (option == 5) 
            {
                BasicPrograms.HollowDimond();
                Console.Write("\nDo you want to Back to Home [ Y / N] : ");
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'Y' || ch == 'y')
                {
                    goto a;
                }
            }
            else
            {
                Console.WriteLine("Enter a valid option !");
                return;
            }
         }
    }
}
