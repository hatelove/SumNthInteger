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
            var sum = numbers.Sum();
            return sum.ToString();
        }
    }
}