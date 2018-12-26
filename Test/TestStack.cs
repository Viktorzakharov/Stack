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
            Assert.AreEqual(startCount, None.Size());
            Assert.IsNull(None.Pop());
            Assert.AreEqual(startCount, None.Size());
        }

        [TestMethod]
        public void TestPop()
        {
            var startCount = StackTest.StackArray.Count;
            Assert.AreEqual(startCount, StackTest.Size());
            var item = StackTest.StackArray[startCount - 1];
            Assert.AreEqual(item, StackTest.Pop());
            Assert.AreEqual(startCount - 1, StackTest.Size());
            Assert.AreNotEqual(item, StackTest.StackArray[startCount - 2]);
        }

        [TestMethod]
        public void TestPush()
        {
            var startCount = StackTest.StackArray.Count;
            Assert.AreEqual(startCount, StackTest.Size());
            var item = 999;
            StackTest.Push(item);
            Assert.AreEqual(startCount + 1, StackTest.Size());
            Assert.AreEqual(item, StackTest.StackArray[startCount]);
        }

        [TestMethod]
        public void TestPeekNone()
        {
            var startCount = None.StackArray.Count;
            Assert.AreEqual(startCount, None.Size());
            Assert.IsNull(None.Peek());
            Assert.AreEqual(startCount, None.Size());
        }

        [TestMethod]
        public void TestPeek()
        {
            var startCount = StackTest.StackArray.Count;
            Assert.AreEqual(startCount, StackTest.Size());
            var item = StackTest.StackArray[startCount - 1];
            Assert.AreEqual(item, StackTest.Peek());
            Assert.AreEqual(startCount, StackTest.Size());
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
