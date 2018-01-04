using System;
using System.Linq;

namespace SumNthInteger
{
    internal class Kata
    {
        public Kata()
        {
        }

        public string SumNthInteger(int n, int maxVal)
        {
            var numberRange = GetNumbers(n);
            var sum = numberRange.Sum();
            if (sum >= maxVal)
            {
                return "input invalid";
            }
            return sum.ToString();
        }

        private int[] GetNumbers(int n)
        {
            var count = Math.Abs(n);
            return Enumerable.Range(1, count).ToArray();
        }
    }
}