using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Stopwatch
{
    class StopwatchDemo
    {
        static void Main()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            LongTimeProcess();
            timer.Stop();

            Console.WriteLine("경과시간 : {0}밀리초", timer.Elapsed.TotalMilliseconds);
            Console.WriteLine("경과시간 : {0}초", timer.Elapsed.Seconds);
        }

        static void LongTimeProcess()
        {
            Thread.Sleep(3000);
        }
    }
}
