using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumNthInteger
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void N_larger_than_numbers_length_And_N_larger_than_0_sum_smaller_than_maxval()
        {
            var numbers = new[] { 4 };
            var n = 3;
            var maxVal = 20;
            ResultShouldBe(numbers, n, maxVal, "4");
        }

        [TestMethod]
        public void N_larger_than_numbers_length_And_N_larger_than_0_sum_larger_than_maxval()
        {
            var numbers = new[] { 40 };
            var n = 3;
            var maxVal = 20;
            ResultShouldBe(numbers, n, maxVal, "input invalid");
        }

        [TestMethod]
        public void N_larger_than_numbers_length_And_N_larger_than_0_sum_equal_to_maxval()
        {
            var numbers = new[] { 20 };
            var n = 3;
            var maxVal = 20;
            ResultShouldBe(numbers, n, maxVal, "input invalid");
        }

        [TestMethod]
        public void N_smaller_than_numbers_length()
        {
            var numbers = new[] { 4, 7, 5 };
            var n = 2;
            var maxVal = 20;
            ResultShouldBe(numbers, n, maxVal, "11");
        }

        [TestMethod]
        public void N_is_0()
        {
            var numbers = new[] { 4, 7, 5 };
            var n = 0;
            var maxVal = 20;
            ResultShouldBe(numbers, n, maxVal, "0");
        }

        [TestMethod]
        public void N_smaller_than_0()
        {
            var numbers = new[] { 4, 7, 5 };
            var n = -2;
            var maxVal = 20;
            ResultShouldBe(numbers, n, maxVal, "11");
        }

        private static void ResultShouldBe(int[] numbers, int n, int maxVal, string expected)
        {
            Assert.AreEqual(expected, new Kata(numbers).SumNthInteger(n, maxVal));
        }
    }
}