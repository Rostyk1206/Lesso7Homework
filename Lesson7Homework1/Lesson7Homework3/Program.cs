using System;

namespace Lesson7Homework3
{
    class Program
    {
        public static void Payment(int payment)
        {
            int debt = 700;

            for(int i=0;i<7;i++)
            {
                if (payment<700 && debt!=0)
                {
                    Console.WriteLine("Enter your count of money:");
                    int count = int.Parse(Console.ReadLine());
                    payment = debt - count;
                    debt = payment;
                    Console.WriteLine($"Your debt is:{debt}");
                }
                else
                {
                    Console.WriteLine("You pay all debt");
                }
            }
        }

        static void Main(string[] args)
        {
            Payment(0);
        }
    }
}
