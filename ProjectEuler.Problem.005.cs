using System.Linq;

namespace ProjectEuler
{
    public class Problem005
    {
        public static long Solution()
        {
            System.Collections.Generic.IEnumerable<int> num = Enumerable.Range(1, 20);
            return Factors.LCM(num.ToArray());
        }
    }
}
