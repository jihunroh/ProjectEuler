using System.Linq;

namespace ProjectEuler
{
    public class Problem001
    {
        public static int Solution()
        {
            return Enumerable.Range(1, 1000 - 1).Where(x => x % 3 ==0 || x % 5 ==0).Sum();
        }
    }
}
