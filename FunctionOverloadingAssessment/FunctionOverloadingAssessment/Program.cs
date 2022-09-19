using System;

namespace FunctionOverloadingAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            area(6);
            area(27, 24);
            area(10, 12);

        }

        public static void area(int r)
        {
            double Cir = Math.PI * r * r;
            Console.WriteLine("Area of circle= " + Cir);
        }
        public static void area(int l, int b)
        {
            int Rec = l * b;
            Console.WriteLine("Area of Rectangle= " + Rec);
        }
        public static void area(int b, float h)
        {
            double Tri = 0.5 * b * h;
            Console.WriteLine("Area of Triangle= " + Tri);
        }
    }
}