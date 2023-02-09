using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverriding
{
   class parent
    {
        public virtual void print()
        {
            Console.WriteLine("this is method of parent class");
        }
    }
    class child : parent 
    {
        public override void print()
        {
           
            Console.WriteLine("this is method of child class");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            child p = new child();
            p.print();
        }
    }
}
