using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class TestPostfixExpression
    {
        [TestMethod]
        public void TestNoneDifferentSymbols()
        {
            var line1 = "";
            var line2 = "1 2 a + 3 b * =";
            Assert.AreEqual(default(double), PostfixExpression.Solve(line1));
            Assert.AreEqual(9, PostfixExpression.Solve(line2));
        }

        [TestMethod]
        public void TestRight()
        {
            var line = "8 2 + 5 * 9 + =";
            Assert.AreEqual(59, PostfixExpression.Solve(line));
        }

        [TestMethod]
        public void TestEqually()
        {
            var line1 = "=";
            var line2 = "5 =";
            var line3 = "5 7 =";
            Assert.AreEqual(default(double), PostfixExpression.Solve(line1));
            Assert.AreEqual(5, PostfixExpression.Solve(line2));
            Assert.AreEqual(7, PostfixExpression.Solve(line3));
        }

        [TestMethod]
        public void TestOperationSymbols()
        {
            var line1 = "5++";
            var line2 = "+";
            Assert.AreEqual(default(double), PostfixExpression.Solve(line1));
            Assert.AreEqual(default(double), PostfixExpression.Solve(line2));
        }
    }
}
