using System;

namespace SumNthInteger
{
    internal class Kata
    {
        public Kata()
        {
        }

        public string SumNthInteger(int n, int maxVal)
        {
            try
            {
                var sum = GetSum(n);
                if (sum >= maxVal)
                {
                    return "input invalid";
                }
                return sum.ToString();
            }
            catch (OverflowException e)
            {
                return "input invalid";
            }
        }

        private int GetSum(int n)
        {
            var count = Math.Abs(n);
            var sum = checked((1 + count) * count / 2);
            return sum;
        }
    }
}