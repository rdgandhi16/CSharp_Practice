using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            Program obj1 = new Program();
           // obj.sum();
           // obj.sumnew
            //obj1.sumnew();

        }

        public void sum()
        {
            int a, b;

            Console.WriteLine("Enter A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine(c);
            Console.ReadLine();

        }
        public void sumnew()
        {
            int a, b;

            Console.WriteLine("Enter A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine(c);
            Console.ReadLine();

        }

    } 
}
