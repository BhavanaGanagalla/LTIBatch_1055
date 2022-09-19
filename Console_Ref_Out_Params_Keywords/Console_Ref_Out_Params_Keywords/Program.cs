using System;
using System.Xml.Serialization;

namespace Console_Ref_Out_Params_Keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Members(1055, "Durga", "Devenedra");

        }
        // params keyword is used to pass an array of undecided length as a parameter

        public static void Members(int branchcode, params string[] names)
        {
            Console.WriteLine("Branch Code is " + branchcode);

            foreach (string n in names)
            {
                Console.WriteLine(" name :" + n);
            }

        }
    }
}