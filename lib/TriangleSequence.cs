﻿using System.Collections.Generic;

namespace ProjectEuler
{
    class TriangleSequence
    {
        public static IEnumerable<int> SequenceBy(int maxNumber)
        {
            int number = 1;
            int i = 2;
            while (number <= maxNumber)
            {
                yield return number;

                number += i;
                i++;
            }
        }
    }
}
