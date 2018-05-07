using System;
using System.Linq;

namespace ProjectEuler
{
    public static class MyExtensions
    {
        public static long Product(this int[] num)
        {
            long product = 1;
            foreach (int digit in num)
            {
                product *= digit;
            }
            return product;
        }
    }
}
