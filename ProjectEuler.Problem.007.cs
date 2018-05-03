using System;
using System.Linq;

namespace ProjectEuler
{
    public class Problem007
    {
        public static long Solution()
        {
            return Factors.PrimeNumber(10001).Max();
        }
    }
}
