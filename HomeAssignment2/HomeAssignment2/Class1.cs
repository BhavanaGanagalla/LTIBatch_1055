using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAssignment2
{
    internal class Class1
    {
        int marks;
        void CalculatePercent()
        {
            int percent = this.marks * 100 / 50;
            Console.WriteLine(percent);
        }
          static void Main(String[] args)   
        {
            Class1 t1 = new Class1();
            t1.marks = 43;
            t1.CalculatePercent();

        }


    }
}


    










