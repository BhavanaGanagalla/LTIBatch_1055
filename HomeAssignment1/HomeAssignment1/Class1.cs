using System;
using System.Collections.Generic;
using System.Text;


    using System;
    using System.Drawing;

    namespace heirrac
    {
        class Program
        {
            static void Main(string[] args)
            {
                Rectangle rec = new Rectangle(12, 5, "red");
                rec.Area();
                Triangle tri = new Triangle(7, 5, "pink");
                tri.Area();
            }
        }
}


    class Triangle : Shape
    {
        public int base1 { get; set; }
        public int height { get; set; }

        public Triangle(int ba, int h, string color, int sides = 2) : base(sides, color)
        {
            base1 = ba;
            height = h;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Triangle: " + (0.5 * base1 * height));
        }
    }

