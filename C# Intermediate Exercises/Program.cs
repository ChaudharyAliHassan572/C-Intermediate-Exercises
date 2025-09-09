using System;
using C__Intermediate_Exercises.Exercises;
public class program
{
       public static void Main(string[] args)
    {
        // Exercise #1
        StopWatch stopWatch = new StopWatch();
        stopWatch.Start ();
        Console.WriteLine("The StopWatch is Started at: " + stopWatch.StartTime);
        stopWatch.Stop();
        Console.WriteLine("The StopWatch is Stopped at: " + stopWatch.StopTime);
        Console.WriteLine(stopWatch.Duration);
    }
}
