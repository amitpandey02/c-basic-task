using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    public class Program
    {
        public int a;
        public int b;
        public Program(int c, int d)
        {
            this.a = c;
            this.b = d;
            
        }
        public void  Add()
        {
            int result = a + b;
            Console.WriteLine("Result is :{0}", result);
        }
        static void Main(string[] args)
        {
            Program p = new Program(20,30);
            p.Add();

        }
    }
}
