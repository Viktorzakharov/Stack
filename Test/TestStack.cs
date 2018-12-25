using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;

namespace Test
{
    [TestClass]
    public class TestStack
    {
        static Stack<string> None = new Stack<string>();
        static Stack<int> StackTest = GenerateStack(new Stack<int>(), 7);
        static int TestItem = 999;

        [TestMethod]
        public void TestPopNone()
        {
            var startCount = None.StackArray.Count;
            Assert.AreEqual(startCount, None.size());
            Assert.IsNull(None.pop());
            Assert.AreEqual(startCount, None.size());
        }

        [TestMethod]
        public void TestPop()
        {
            var startCount = StackTest.StackArray.Count;
            Assert.AreEqual(startCount, StackTest.size());
            var item = StackTest.StackArray[startCount - 1];
            Assert.AreEqual(item, StackTest.pop());
            Assert.AreEqual(startCount - 1, StackTest.size());
            Assert.AreNotEqual(item, StackTest.StackArray[startCount - 2]);
        }

        [TestMethod]
        public void TestPush()
        {
            var startCount = StackTest.StackArray.Count;
            Assert.AreEqual(startCount, StackTest.size());
            var item = 999;
            StackTest.push(item);
            Assert.AreEqual(startCount + 1, StackTest.size());
            Assert.AreEqual(item, StackTest.StackArray[startCount]);
        }

        [TestMethod]
        public void TestPeekNone()
        {
            var startCount = None.StackArray.Count;
            Assert.AreEqual(startCount, None.size());
            Assert.IsNull(None.peak());
            Assert.AreEqual(startCount, None.size());
        }

        [TestMethod]
        public void TestPeek()
        {
            var startCount = StackTest.StackArray.Count;
            Assert.AreEqual(startCount, StackTest.size());
            var item = StackTest.StackArray[startCount - 1];
            Assert.AreEqual(item, StackTest.peak());
            Assert.AreEqual(startCount, StackTest.size());
            Assert.AreEqual(item, StackTest.StackArray[startCount - 1]);
        }

        static Stack<int> GenerateStack(Stack<int> stack, int count)
        {
            var random = new Random();
            for (int i = 0; i < count; i++)
                stack.StackArray.Add(random.Next(255));
            return stack;
        }
    }
}
