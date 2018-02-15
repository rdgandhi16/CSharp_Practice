using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @static
{
    class Program
    {
        static int a=10;
        static int b=10;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.sum();
     
        }

         void sum()
        {
            int c = Program.a + Program.b;
            Console.WriteLine(c);
            Console.ReadLine();
             

        }
    }
}
