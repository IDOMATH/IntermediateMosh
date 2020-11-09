using System;
using System.Collections.Generic;

namespace Stopwatch
{
    public class Stopwatch
    {
        // List to hold each segment of start/stop
        private readonly List<TimeSpan> Segments = new List<TimeSpan>();
        // DateTime for start button pressed
        private DateTime StartTime { get; set; }
        private bool IsStarted { get; set; }

        // Constructor
        public Stopwatch()
        {
            IsStarted = false;
        }

        // Start method
        public void Start()
        {
            if (!IsStarted)
            {
                StartTime = DateTime.Now;
                IsStarted = true;
            }
        }
        // Stop method
        public void Stop()
        {
            if (IsStarted)
            {
                Segments.Add(DateTime.Now - StartTime);
                IsStarted = false;
            }
        }
        // Clear method
        public void Clear()
        {
            StartTime = DateTime.Now;
            Segments.Clear();
        }
        // Display Time
        public void DisplayTime()
        {
            TimeSpan total = new TimeSpan(0);
            if (IsStarted)
            {
                total = total.Add(DateTime.Now - StartTime);
            }

            foreach(TimeSpan segment in Segments)
            {
                total = total.Add(segment);
            }
            Console.WriteLine("Time elapsed: {0}", total);
        }
    }
}
