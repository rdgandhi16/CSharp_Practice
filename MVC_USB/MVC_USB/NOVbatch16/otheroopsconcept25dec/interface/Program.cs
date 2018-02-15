using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @interface
{
   public  interface one
   {
       void one();
   }
   public interface two
   {
       void two();
   }
   public interface three
   {
       void three();
   }
   public interface four
   {
       void four();
   }
   class oddeven:one,two,three,four
   {
       public void one()
       {
           Console.WriteLine("One");
           Console.ReadLine();
       }
       public void two()
       {
           Console.WriteLine("two");
           Console.ReadLine();
       }
       public void three()
       {
           Console.WriteLine("three");
           Console.ReadLine();
       }
       public void four()
       {
           Console.WriteLine("Four");
           Console.ReadLine();
       }

   }

    class Program
    {
        static void Main(string[] args)
        {
            one o = new oddeven();
            o.one();

            two t = new oddeven();
            t.two();

            three th = new oddeven();
            th.three();

            four f=new oddeven();
            f.four();
        }
    }
}
