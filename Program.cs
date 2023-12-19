using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradutaion_Project
{
    internal class Program
    {
        static bool Loop = false;
        static void Main(string[] args)
        {
            List<bank> bank = new List<bank>();
            int chose;
            while (Loop != true)
            {
                Console.WriteLine($"1-Add client \n2-Withdrawal process \n3-Deposit process \n");
                Console.Write("Chose a number => ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out chose))
                {
                    if (chose == 1)
                    {
                        Add adduser = new Add();
                        adduser.Bank(bank);
                    }
                    else if (chose == 2)
                    {
                        Add Withdrawal = new withdraw();
                        Withdrawal.Bank(bank);
                    }
                    else if (chose == 3)
                    {
                        Add Deposit = new deposit();
                        Deposit.Bank(bank);
                    }
                    else
                    {
                        Console.WriteLine("You Enter Wrong Number!!");

                    }

                    TryAgain();
                    if (Loop)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("=========================================================================");
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.WriteLine("=========================================================================");
                }
            }
        }
        static void TryAgain()
        {
            Console.WriteLine("=========================================================================");

            Console.WriteLine("Do you want to try anything else ? \n (Y/y for yes || N/n for no)");
            char tryAgain = char.Parse(Console.ReadLine());
            if (tryAgain == 'Y' || tryAgain == 'y')
            {
                Console.WriteLine("=========================================================================");
            }
            else if (tryAgain == 'N' || tryAgain == 'n')
            {
                Loop = true;
            }
        }
    }
}