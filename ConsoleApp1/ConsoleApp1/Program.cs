using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public delegate int MyDelegate(int num, int num1);
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate obj = (a,b) =>
            {
                int c = a + b;
                return c;
               
                Console.WriteLine(c);
            };
           int num = obj.Invoke(10,20);
            Console.WriteLine(num);
        }
    }
}
