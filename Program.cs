using System;
using System.Reflection;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var elapsedMs = watch.ElapsedMilliseconds;

            int problemNumber = 2;
            int problemSolution;

            problemSolution = Problem002.Solution();
            watch.Stop();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("   Project Euler: Problem #{0}", problemNumber);
            Console.WriteLine("   The Answer is: {0}", problemSolution);
            Console.WriteLine("   Time Elasped: {0}ms", elapsedMs);
            Console.WriteLine("------------------------------------------------");
            //Console.ReadKey();
            Console.Read();
        }
    }
}
