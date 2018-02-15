using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 2, 4, 6, 3, 5, 7 };
            foreach (var result in number)
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
            Console.ReadLine();
        }
    }
}
