﻿using System;
using System.Linq;

namespace ProjectEuler
{
    public class Problem007
    {
        public static long Solution()
        {
            return Factors.PrimeNumberNth(10001).Max();
        }
    }
}
