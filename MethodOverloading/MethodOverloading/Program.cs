using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Program
    {
        public void Add(int a, int b) 
        {
            int result = a + b;
            Console.WriteLine("Addition of two integer number:{0}",result);
        }
        public void Add(string a, string b) 
        {
            string result=a+ b;
            Console.WriteLine("Addition of two string  :"+result);
        }
        public void Add(float a, float b) 
        {
            float result=a+ b;
            Console.WriteLine("Addition of two float number :" + result);
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.Add(50, 60);
            p.Add(20.0f, 10.00f);
            p.Add("amit ", "pandey");
        }
    }
}
