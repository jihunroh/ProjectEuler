using System.Linq;
using System.Collections.Generic;

namespace ProjectEuler
{
    public class Problem004
    {
        public static int Solution()
        {
            return PalindromicNumberList().Max();
        }
        public static IEnumerable<int> PalindromicNumberList()
        {
            for (int a = 999; a >= 100; a--)
            {
                for (int b = 999; b >= a; b--)
                {
                    if (isPalindromic(a * b))
                        yield return a * b;
                }

            }
        }
        public static bool isPalindromic(int num)
        {
            string strNum = num.ToString();
            int halfLength = strNum.Length / 2;
            for (int i=0; i <= halfLength; i++)
            {
                if (strNum[i] != strNum[strNum.Length - 1 - i])
                    return false;
            }

            return true;
        }
    }
}
