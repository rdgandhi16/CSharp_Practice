using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @delegate
{
    class Program
    {
        delegate  void sum(int a,int b);

        static  public void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            sum s = add;
            s.Invoke(10, 20);
        }
    }
}
