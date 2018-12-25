using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;

namespace Test
{
    [TestClass]
    public class TestFindBracketsBalance
    {
        [TestMethod]
        public void TestBracketsBalance1()
        {
            var line = "( sn)(()((()(dj))))";
            Assert.IsTrue(FindBracketsBalance.BracketsBalance(line));
        }

        [TestMethod]
        public void TestBracketsBalance2()
        {
            var line = ")(wnw()";
            Assert.IsFalse(FindBracketsBalance.BracketsBalance(line));
        }

        [TestMethod]
        public void TestBracketsBalance3()
        {
            var line = "(js( k)j()";
            Assert.IsFalse(FindBracketsBalance.BracketsBalance(line));
        }

        [TestMethod]
        public void TestBracketsBalance4()
        {
            var line = "";
            Assert.IsTrue(FindBracketsBalance.BracketsBalance(line));
        }
    }
}
