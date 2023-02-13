using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out
{
  public class Program
    {
        /*
        static void PassByRef(ref int a)
        {
            a = a + 10;
            Console.WriteLine("value is:"+a);
        }
        static void Main(string[] args)
        {
            int value = 5;

            PassByRef(ref value);
            Console.WriteLine(value);
        }
        */

        static void PassByOut(out int a)
        {
            a = 20;
            Console.WriteLine("value is "+a);
        }
        static void Main(string[] args)
        {
            int value;
            PassByOut(out value);
            Console.WriteLine(value);

        }
    }
}
