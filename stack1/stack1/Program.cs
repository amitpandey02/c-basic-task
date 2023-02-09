using System;
using System.Collections;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace stack1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack s= new Stack();
            s.Push(1);
            s.Push("amit");
            s.Push(2.05f);
            s.Push('A');
            s.Push(299.006d);
            s.Push(true);
            foreach (object item in s)
            {
                Console.WriteLine(item);
            }
           // Console.WriteLine(s.Peek());
            //Console.WriteLine(s.Contains('A'));
            s.Pop();
            Console.WriteLine("--------------");
            foreach (object item in s)
             {
              Console.WriteLine(item);
            }
        }
    }
}
