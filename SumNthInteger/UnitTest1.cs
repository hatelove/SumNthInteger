using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumNthInteger
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void new_n_is_0()
        {
            var n = 0;
            var maxVal = 300;
            ResultShouldBe(n, maxVal, "0");
        }

        [TestMethod]
        public void new_n_is_1()
        {
            var n = 1;
            var maxVal = 300;
            ResultShouldBe(n, maxVal, "1");
        }

        [TestMethod]
        public void sum_is_larger_than_maxval()
        {
            var n = 1;
            var maxVal = 0;
            ResultShouldBe(n, maxVal, "input invalid");
        }

        private void ResultShouldBe(int n, int maxVal, string expected)
        {
            Assert.AreEqual(expected, new Kata().SumNthInteger(n, maxVal));
        }
    }
}