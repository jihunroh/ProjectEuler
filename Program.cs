using System;
using System.Reflection;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int problemNumber = 14;
            long problemSolution;

            problemSolution = (long) Problem014.Solution();
            watch.Stop();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("   Project Euler: Problem #{0}", problemNumber);
            Console.WriteLine("   The Answer is: {0}", problemSolution);
            Console.WriteLine("   Time Elasped: {0}ms", watch.ElapsedMilliseconds);
            Console.WriteLine("------------------------------------------------");
            Console.Read();
        }
    }
}
