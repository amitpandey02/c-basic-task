using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_Dynamic_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var v = "Amit";
            //var v = 5;
            // can not intialize twice

            dynamic d = 5;
            d = "pandey";

            object o = 5;
            o = "pandey1";

            // OBJECT
            //String s = o;
            // we need to explicitly conver it
            String s=o.ToString();

            //Dynamic
            //implicitly converted
            String s1 = d;

            //Var
            string s2 = v;

            Console.WriteLine("var :"+v);
            Console.WriteLine("dynamic :"+d);
            Console.WriteLine("object :"+o);
            Console.WriteLine(s);
            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
