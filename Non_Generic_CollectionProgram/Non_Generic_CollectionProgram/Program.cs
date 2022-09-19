using System;
using System.Collections;

namespace Non_Generic_CollectionProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList mylist = new ArrayList();
            mylist.Add(12);
            mylist.Add(25.50m);
            mylist.Add(3.4098f);
            mylist.Add(Math.PI);
            //there is a process called boxing
            //value type to its original value type conversion mean boxing
            foreach(var obj in mylist)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("count of mylist ="+mylist.Count);
            mylist.Add(new Student());



        }
    }
}
