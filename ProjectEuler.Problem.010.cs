using System;
using System.Linq;

namespace ProjectEuler
{
    public class Problem010
    {
        public static long Solution()
        {
            return Factors.PrimeNumberBelow(2000000).Sum();
        }
    }
}