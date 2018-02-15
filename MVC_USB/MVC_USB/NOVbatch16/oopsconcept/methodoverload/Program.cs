using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace methodoverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.sum(10);
            obj.sum(10, 20);
        }

        public void sum(int a)
        {
            int b = a + a;
            Console.WriteLine(b);
           // Console.ReadLine();

        }
        public void sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
