using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolationTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Amit";
            string a = "pandey";
            Console.WriteLine("hello "+s+" "+a); 

            //String Interpolation
            Console.WriteLine($"hello {s} {a}");


            Stopwatch sw1 = new Stopwatch();

            sw1.Start();
            for (int i = 0; i < 100000; i++)
            {
                s = s + i;
            }
            sw1.Stop();
            StringBuilder sb = new StringBuilder("Hello");
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();
            Console.WriteLine("Time taken by string :" + sw1.ElapsedMilliseconds);
            Console.WriteLine("Time taken by stringbuilder :" + sw2.ElapsedMilliseconds);
        }
    }
}
