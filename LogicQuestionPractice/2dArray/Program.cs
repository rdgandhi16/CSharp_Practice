using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] name = new string[,] { { "Rinkal", "Roma" }, { "Gandhi", "Modi" } };

            int r = name.GetLength(0);
            int c = name.GetLength(1);

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(name[i, j]+" ");
                }
               Console.WriteLine("\n");
                Console.ReadLine();
            }

        }
    }
}
