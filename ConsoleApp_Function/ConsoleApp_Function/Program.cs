using System;

namespace ConsoleApp_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sum(12, 24);
            Console.ReadKey();
        }
        public static void sum(int a, int b)
        {
            Console.WriteLine("{0}+{1}={2}", a, b, (a + b));

        }
    }
}

   


