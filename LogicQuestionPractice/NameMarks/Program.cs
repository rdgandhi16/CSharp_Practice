using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[3];
            string[] name = new string[3];

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Name");
                name[i] = Console.ReadLine();
                Console.Write("Marks \n");
                marks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Name  \t   Mark");
            for (int j = 0; j < marks.Length; j++)
            {
                Console.WriteLine(name[j] + "     "+ marks[j]);
            }
            Console.ReadLine();
        }
    }
}
