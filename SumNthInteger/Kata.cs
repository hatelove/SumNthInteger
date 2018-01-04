using System.Linq;

namespace SumNthInteger
{
    internal class Kata
    {
        private int[] numbers;

        public Kata(int[] numbers)
        {
            this.numbers = numbers;
        }

        public string SumNthInteger(int n, int maxVal)
        {
            var sum = numbers.Take(n).Sum();
            if (sum >= maxVal)
            {
                return "input invalid";
            }
            return sum.ToString();
        }
    }
}