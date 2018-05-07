using System;
using System.Linq;

namespace ProjectEuler
{
    public class Problem009
    {
        public static long? Solution()
        {
            var arrA = Enumerable.Range(1, 1000);
            foreach (int A in arrA)
            {
                var arrB = Enumerable.Range(A + 1, 1000);
                foreach (int B in arrB)
                {
                    int C = 1000 - A - B;
                    if (A * A + B * B == C * C)
                    {
                        return A * B * C;
                    }
                }
            }
            return null;
        }
    }
}