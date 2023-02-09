using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace stopwatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sw = new StopWatch();
            for (var i = 0; i < 2; i++)
            {
                sw.Start();
               
                Thread.Sleep(1000);
    
                
                //sw.Start(DateTime.Now);

                sw.Stop();
                Console.WriteLine("Duration :" + sw.GetInterval());
                Console.WriteLine("Press Enter to run stopwatch one more Time");
                Console.ReadLine();
            }
        }
    }
    public class StopWatch 
        {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running;
        public void Start() 
        {
            if(_running)
            {
                throw new InvalidOperationException("StopWatch is already running");
            }
            
                _startTime = DateTime.Now;
                _running = true;
            
        }
        public void Stop()
        {
            if(!_running)
                throw new InvalidOperationException("StopWatch is not running");
            
                _endTime= DateTime.Now;
                _running= false;
            
        }
        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
            
        }

    }
}
