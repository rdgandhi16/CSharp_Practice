using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            stud obj = new stud();
            obj.sum();

        }
    }

    class math
    {

        protected int a;
        protected int b;
        public void sum()
        {
            Console.WriteLine("Enter A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B:");
            b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
    class stud : math
    {
        public void sum()
        {
            Console.WriteLine("Enter A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B:");
            b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }





}
