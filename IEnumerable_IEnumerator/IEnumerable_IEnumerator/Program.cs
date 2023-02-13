using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator
{
    public class Program
    {
        /*
        static void show1(IEnumerator<int> i)
        {
            while(i.MoveNext())
            {
                Console.WriteLine(i.Current);
                if (i.Current == 44)
                    show2(i);
            }
        }
        static void show2(IEnumerator<int> i)
        {
            while(i.MoveNext()) 
            {
            Console.WriteLine(i.Current);
            }

        }
        static void Main(string[] args)
        {
            List<int> numbers=new List<int>() { 11,22,33,44,55,66,77};
            IEnumerator<int> nums=numbers.GetEnumerator();
            show1(nums);
        

        }
        */

        static void show1(IEnumerable<int> i)
        {
            foreach (var item in i)
            {
                Console.WriteLine(item);
                if (item == 44)
                {
                    show2(i);
                }
            }

        }
        static void show2(IEnumerable<int> i) 
        {
            foreach (var item in i)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args) 
        {
            List<int> numbers= new List<int>() { 11,22,33,44,55,66,77};
            IEnumerable<int> nums= (IEnumerable<int>)numbers;
            show1(nums);
        }
    }
}
