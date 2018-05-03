using System;
using System.Linq;

namespace ProjectEuler
{
    public class Problem006
    {
        public static long Solution()
        {
            const int max = 100;
            long SquareOfSum = Enumerable.Range(1, max).Select(selector: x => x * x).Sum();
            long SumOfSquares = (long) Math.Pow(Enumerable.Range(1, max).Sum(), 2);
            return SumOfSquares - SquareOfSum;
        }
    }
}
