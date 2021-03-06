﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjectEuler
{
    public static class Factors
    {
        /*
         * 입력받은 num의 소인수 목록을 차례대로 반환
         */
        public static IEnumerable<int> PrimeFactorsList(long num)
        {
            int divisor = 2;
            while (num % divisor == 0)
            {
                yield return divisor;
                num /= divisor;
            }

            divisor = 3;

            while (divisor <= num)
            {
                while (num % divisor == 0)
                {
                    yield return divisor;
                    num /= divisor;
                }

                divisor += 2;
            }

        }
        public static int[] FactorsList(int number)
        {
            double sqrtNumber = Math.Pow(number, 0.5);
            var factorsList = Enumerable.Range(1, (int)Math.Ceiling(sqrtNumber) - 1).Where(x => number % x == 0).ToList();
            factorsList = factorsList.Concat(factorsList.Select(x => number / x)).ToList();
            if ((int)sqrtNumber * (int)sqrtNumber == number)
                factorsList.Add( (int)sqrtNumber );
            return factorsList.ToArray();
        }
        public static IEnumerable<long> PrimeNumberNth(int index)
        {
            yield return 2;
            long num = 3;
            int i = 1;
            do
            {
                if (Factors.IsPrime(num))
                {
                    yield return num;
                    i++;
                }
                num += 2;
            } while (i < index);
        }
        public static IEnumerable<long> PrimeNumberBelow(int upperBound)
        {
            yield return 2;
            long num = 3;
            do
            {
                if (Factors.IsPrime(num))
                {
                    yield return num;
                }
                num += 2;
            } while (num < upperBound);
        }
        public static long GCD(int[] num)
        {
            long candidateGCD = num[0];
            for (int i=1; i < num.Length; i++)
            {
                candidateGCD = GCD2(candidateGCD, num[i]);
            }
            return candidateGCD;
        }
        public static long LCM(int[] num)
        {
            long candidateLCM = (long) num[0];
            for (int i = 1; i < num.Length; i++)
            {
                //Console.WriteLine("{0}과 {1}의 최소공배수는 {2}", candidateLCM, num[i], LCM2(candidateLCM, num[i]));
                candidateLCM = LCM2(candidateLCM, num[i]);
            }
            return candidateLCM;
        }
        public static long GCD2(long a, long b)
        {
            if (a >= b) {
                return (a % b == 0) ? b : GCD2(b, a % b);
            } else
            {
                return (b % a == 0) ? a : GCD2(a, b % a);
            }
        }

        public static long LCM2(long a, long b)
        {
            return a * b / GCD2(a, b);
        }
        
        public static bool IsPrime(long num)
        {
            long maxFactor = (long) Math.Sqrt(num);
            int factor = 2;
            if (num % factor == 0)
                return false;
            for (factor=3; factor <= maxFactor; factor+=2)
            {
                if (num % factor == 0)
                    return false;
            }
            return true;
        }
    }
}