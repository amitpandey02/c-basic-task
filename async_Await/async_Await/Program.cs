using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace async_Await
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadLine();
        }
        //With Async and Await
        /*lic static async void Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task1 Starting");
                Thread.Sleep(4000);
                Console.WriteLine("Task1 Completed");
            });
            
        }
        public static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task2 Starting");
                Thread.Sleep(2000);
                Console.WriteLine("Task2 Completed");
            });
            Console.WriteLine("Hello amit");
        }
        public static async void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task3 Starting");
                Thread.Sleep(5000);
                Console.WriteLine("Task3 Completed");
            });
        }
        public static async void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task4 Starting");
                Thread.Sleep(1000);
                Console.WriteLine("Task4 Completed");
            });
        }
        */

        //Without Async and Await

        public static  void Task1()
        {
           
                Console.WriteLine("Task1 Starting");
                Thread.Sleep(4000);
                Console.WriteLine("Task1 Completed");
            

        }
        public static  void Task2()
        {
            
                Console.WriteLine("Task2 Starting");
                Thread.Sleep(2000);
                Console.WriteLine("Task2 Completed");
           
            Console.WriteLine("Hello amit");
        }
        public static void Task3()
        {
            Console.WriteLine("Task3 Starting");
            Thread.Sleep(5000);
            Console.WriteLine("Task3 Completed");
        }
           
        public static void Task4()
        {
            
                Console.WriteLine("Task4 Starting");
                Thread.Sleep(1000);
                Console.WriteLine("Task4 Completed");
            
        }

    }
}
