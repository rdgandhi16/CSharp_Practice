using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String Please");
            string str = Console.ReadLine();

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
            Console.ReadLine();
        }
    }
}
