using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseStopwatch
{
    class Stopwatch
    {
        private TimeSpan duration;
        private DateTime tempStart;
        private bool started = false;

        public void Start()
        {
            if (started)
            {
                throw new InvalidOperationException("Stopwatch already started!");
            }
            else
            {
                tempStart = DateTime.Now;
                started = true;
            }
        }

        public void Stop()
        {
            if (!started)
            {
                throw new InvalidOperationException("First you need to start the stopwatch!");
            }
            else
            {
                duration = DateTime.Now - tempStart;
                started = false;
            }
        }

        public void printDuration()
        {
            if (!started)
            {
                int minutes = duration.Minutes;
                int seconds = duration.Seconds;
                int milliseconds = duration.Milliseconds;

                Console.WriteLine("Duration: " + minutes + " minutes " + seconds + " seconds " + milliseconds+" milliseconds");
            }
            else
            {
                throw new InvalidOperationException("Stop the watch before printing out the duration!");
            }
        }
    }
}
