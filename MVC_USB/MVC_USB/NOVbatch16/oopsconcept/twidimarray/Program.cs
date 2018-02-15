using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace twidimarray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] name = new string[,] { { "tops", "abc" }, { "krunal", "Pratik" } };

            int r = name.GetLength(0);
            int c = name.GetLength(1);

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                        
                    Console.Write(name[i,j]+"   ");
                    
                }
                
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
