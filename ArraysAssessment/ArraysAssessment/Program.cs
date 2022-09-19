using System;

namespace ArraysAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Friends("Kiruthika", "Chandrika", "Devendra", "John", "Shivani", "Ruthvik", "Likitha", );

            }

             static void Friends(params string[] names)
            {
                Array.Sort(names);
                foreach (string n in names)
                {

                    Console.WriteLine(" Name :" + n);

                }

            }

        }
    }
}
