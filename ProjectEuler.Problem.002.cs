using System.Linq;

namespace ProjectEuler
{
    public class Problem002
    {
        public static int Solution()
        {
            return FibonacciSequence.sequenceBy(4000000).Where(x => x % 2 == 0).Sum();
        }
    }
}
