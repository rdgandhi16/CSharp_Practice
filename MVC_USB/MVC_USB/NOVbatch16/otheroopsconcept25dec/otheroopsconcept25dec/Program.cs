using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace otheroopsconcept25dec
{
    class Program
    {
        static void Main(string[] args)
        {
            shape sh;
            sh = new shape();
            sh.sum();
            sh = new square();
            sh.sum();           
        }

    }

    class shape
    {
        public int a;
        public int b;

        public void sum()
        {
            int c = 10 + 10;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
    class square : shape
    {
        public void sum()
        {
            int c = 10 + 20;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
