using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            other ot = new other();
            ot.sum();

        }
    }

    abstract class test
    {
        abstract public void sum();
    }
    class other : test
    {
        public override void sum()
        {
            //throw new NotImplementedException();
            int c = 10 + 10;
            Console.WriteLine(c);
            Console.ReadLine();

        }
    }
}
