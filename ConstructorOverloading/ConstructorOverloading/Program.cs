using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    public class Program
    {
        public int x, y;
        public float x2, y2;
        public Program(int a, float b)
        {
           this.x = a;
            this.x2 = b;
        }
        public Program( float a, int b)
        {
            this.y2 = a;
            this.y = b;

        }
        public void  Add()
        {
            float result= x + x2;
            Console.WriteLine("Addition is :" + result);

        }
        public void Subtract()
        { float result= y - y2;
            Console.WriteLine("Subtraction is :{0}", result);

        }
        static void Main(string[] args)
        {
            Program p = new Program(20, 15.04f);
            Program p1 = new Program(15.04f, 20);
            p.Add(); 
            p1.Subtract();
           
        }
    }
}
