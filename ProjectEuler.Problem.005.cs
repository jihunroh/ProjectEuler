using System.Linq;
using System.Collections.Generic;

namespace ProjectEuler
{
    public class Problem005
    {
        public static long Solution()
        {
            IEnumerable<int> num = Enumerable.Range(1, 20);
            return Factors.LCM(num.ToArray());
        }
    }
}
