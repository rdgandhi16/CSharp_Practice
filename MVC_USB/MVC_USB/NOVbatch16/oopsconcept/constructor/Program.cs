using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            
        }

       ~Program()
        {
            Console.WriteLine("hello");
            Console.ReadLine();
          
        }
    }
}
