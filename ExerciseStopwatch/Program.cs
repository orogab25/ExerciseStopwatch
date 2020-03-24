using System;

namespace ExerciseStopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            /*stopwatch.Stop();*/
            stopwatch.Start();
            /*stopwatch.Start();*/
            /*stopwatch.printDuration();*/
            stopwatch.Stop();
            stopwatch.printDuration();
        }
    }
}
