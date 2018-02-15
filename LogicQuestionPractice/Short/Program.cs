using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] num = { 1, 4, 2, 5, 6, 7, 9, 11 };
            //Array.Sort(num);
            //foreach (var item in num)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            
            string[] name = { "a", "b", "z", "e" };
            Array.Sort(name);
            foreach (var alphabet in name)
            {
                Console.WriteLine(alphabet);
            }
            Console.ReadLine();
        }
    }
}
