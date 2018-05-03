using System;
using System.Linq;

namespace ProjectEuler
{
    public class Problem003
    {
        public static int Solution()
        {
            long num = 600851475143;
            return Factors.PrimeFactorsList(num).Max();
        }
    }
}
