using System;

namespace Lesson7Homework4
{
    class Program
    {
        public static int Factorial(int number)
        {
            if (number==0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many clients are:");
           int number = int.Parse(Console.ReadLine());
            int route = Factorial(number);
            Console.WriteLine($"There are {route} route!");
        }
    }
}
