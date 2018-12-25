using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;

namespace Test
{
    [TestClass]
    public class TestStackHead
    {
        static StackHead<string> None = new StackHead<string>();
        static StackHead<int> StackTest = GenerateStack(new StackHead<int>(), 7);
        static int TestItem = 999;

        [TestMethod]
        public void TestPopNone()
        {
            var startCount = None.StackList.GetLength();
            Assert.AreEqual(startCount, None.size());
            Assert.IsNull(None.pop());
            Assert.AreEqual(startCount, None.size());
        }

        [TestMethod]
        public void TestPop()
        {
            var startCount = StackTest.StackList.GetLength();
            Assert.AreEqual(startCount, StackTest.size());
            var item = StackTest.StackList.GetHead().value;
            Assert.AreEqual(item, StackTest.pop());
            Assert.AreEqual(startCount - 1, StackTest.size());
            Assert.AreNotEqual(item, StackTest.StackList.GetHead().value);
        }

        [TestMethod]
        public void TestPush()
        {
            var startCount = StackTest.StackList.GetLength();
            Assert.AreEqual(startCount, StackTest.size());
            var item = 999;
            StackTest.push(item);
            Assert.AreEqual(startCount + 1, StackTest.size());
            Assert.AreEqual(item, StackTest.StackList.GetHead().value);
        }

        [TestMethod]
        public void TestPeekNone()
        {
            var startCount = None.StackList.GetLength();
            Assert.AreEqual(startCount, None.size());
            Assert.IsNull(None.peak());
            Assert.AreEqual(startCount, None.size());
        }

        [TestMethod]
        public void TestPeek()
        {
            var startCount = StackTest.StackList.GetLength();
            Assert.AreEqual(startCount, StackTest.size());
            var item = StackTest.StackList.GetHead().value;
            Assert.AreEqual(item, StackTest.peak());
            Assert.AreEqual(startCount, StackTest.size());
            Assert.AreEqual(item, StackTest.StackList.GetHead().value);
        }

        static StackHead<int> GenerateStack(StackHead<int> stack, int count)
        {
            var random = new Random();
            for (int i = 0; i < count; i++)
                stack.StackList.AddInTail(new Node<int>(random.Next(255)));
            return stack;
        }
    }
}
