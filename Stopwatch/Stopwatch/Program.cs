using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            stopwatch.DisplayTime();
            Thread.Sleep(1000);
            stopwatch.DisplayTime();

            stopwatch.Stop();
            stopwatch.DisplayTime();
            Thread.Sleep(500);
            stopwatch.DisplayTime();

            stopwatch.Start();
            Thread.Sleep(500);
            stopwatch.DisplayTime();
            stopwatch.Clear();
            Thread.Sleep(250);
            stopwatch.DisplayTime();

            stopwatch.Start();
            stopwatch.DisplayTime();

            stopwatch.Stop();
            stopwatch.DisplayTime();
        }
    }
}
