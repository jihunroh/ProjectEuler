using System;
using System.Linq;

namespace ProjectEuler
{
    public class Problem012
    {
        public static long? Solution()
        {
            foreach (int num in TriangleSequence.SequenceBy(Int32.MaxValue))
            {
                if (Factors.FactorsList(num).Count() > 500)
                    return num;
            }
            return null;
        }
    }
}