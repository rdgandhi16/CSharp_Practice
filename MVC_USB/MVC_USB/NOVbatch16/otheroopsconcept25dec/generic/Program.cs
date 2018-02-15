using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generic
{
    class test<T>
    {
        T ob1;
        public test(T t1)
        {
            ob1 = t1;
        }

        public void display()
        {
            Console.WriteLine(ob1);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            test<int> t = new test<int>(10);
            t.display();

            test<string> t1 = new test<string>("abc");
            t1.display();
        }
    }
}
