using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04TryItOut05
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, interestRate, targetBalance;
            Console.Write("What id your current balance? ");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is your current annual interest rate (in %)? ");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.Write("What balance would you like to have? ");
            do
            {
                targetBalance = Convert.ToDouble(Console.ReadLine());
                if (targetBalance <= balance)
                {
                    Console.Write("You must enter an amount grater than your current balance!\nPlease enter another value. ");
                }
            }
            while (targetBalance <= balance);
            int totalYears = 0;
            while(balance < targetBalance)
            {
                balance *= interestRate;
                ++totalYears;
            }
            Console.WriteLine("In {0} year {1} you'll have a balance of {2}.", totalYears, totalYears == 1 ? "" : "s", balance);
            Console.ReadKey();
        }
    }
}
