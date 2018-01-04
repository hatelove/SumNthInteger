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
            var expected = "4";

            string actual = new Kata(numbers).SumNthInteger(n, maxVal);
            Assert.AreEqual(expected, actual);
        }
    }
}