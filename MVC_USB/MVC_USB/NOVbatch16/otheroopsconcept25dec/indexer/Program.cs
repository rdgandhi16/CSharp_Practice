using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace indexer
{
    class Program
    {
        string[] str = new string[3];

        public string this[int i]
        {
            get 
            {
                return str[i];
            }
            set
            {
                str[i] = value;
            }

        }
        
        static void Main(string[] args)
        {
            Program prog = new Program();

            prog[0] = "a";
            prog[1] = "b";
            prog[2] = "c";

            Console.WriteLine("{0}{1}{2}",prog[0],prog[1],prog[2]);
            Console.ReadLine();
        }
    }
}
