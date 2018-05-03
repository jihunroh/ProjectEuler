namespace ProjectEuler
{
    class FibonacciSequence
    {
        public static System.Collections.Generic.IEnumerable<int> SequenceBy(int maxNumber)
        {
            int a0 = 1;
            int a1 = 2;
            int a2;

            while (a0 <= maxNumber)
            {
                yield return a0;
                
                a2 = a0 + a1;
                a0 = a1;
                a1 = a2;
            }
        }
    }
}
