using System;

namespace SwitchCaseAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int a, b;
                char operation;
                Console.WriteLine("Enter a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter an operation(+, -, *,/):  ");
                operation = Convert.ToChar(Console.ReadLine());

                switch (operation)
                {

                    case '+':
                        Console.WriteLine("{0}+{1}={2}", a, b, (a + b));
                        break;

                    case '-':
                        Console.WriteLine("{0}-{1}={2}", a, b, (a - b));
                        break;

                    case '*':
                        Console.WriteLine("{0}*{1}={2}", a, b, (a * b));
                        break;

                    case '/':
                        Console.WriteLine("{0}/{1}={2}", a, b, (a / b));
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        
}
    }
}
