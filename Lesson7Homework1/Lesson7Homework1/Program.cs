using System;

namespace Lesson7Homework1
{
    class Program
    {
        static void Calculate (ref int a, ref int b, ref int c)
        {
            a  /= 5;
            b /= 5;
            c /= 5;
        }
        static void Main(string[] args)
        {
            int x=10;
            int y = 15;
            int i = 20;
            Calculate(ref x, ref y, ref i);
            Console.WriteLine($" {x}\n {y}\n {i}\n");
        }
    }
}
