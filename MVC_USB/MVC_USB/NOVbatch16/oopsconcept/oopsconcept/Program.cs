using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopsconcept
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] marks=new int[3];
            string[] name = new string[3];

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Enter Name:");
                name[i] = (string)Console.ReadLine();
                Console.WriteLine("Enter Marks");
                marks[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Students Name \t Marks");

            for (int j = 0; j < marks.Length; j++)
            {
                Console.WriteLine(name[j]+ "\t\t"+marks[j]);

            }
            Console.ReadLine();

        }
    }
}
