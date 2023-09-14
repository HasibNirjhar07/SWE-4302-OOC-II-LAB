using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;
using System;

namespace StackTest
{
    [TestClass]
    public class Stacktest
    {
        [TestMethod]
        public void minValueTest()
        {
            MinStack minStack = new MinStack();
            minStack.Push(7);
            minStack.Push(3);
            minStack.Push(5);
            minStack.Push(2);
            minStack.Push(7);
            Assert.AreEqual(2, minStack.min());
        }
        [TestMethod]
        public void pushValueTest()
        {
            MinStack minStack = new MinStack();
            minStack.Push(7);
            minStack.Push(3);
            minStack.Push(5);
            minStack.Push(2);
            minStack.Push(7);
            Assert.AreEqual(7, minStack.stack.Peek());
        }

        [TestMethod]

        public void popValueTest()
        {
            MinStack minStack = new MinStack();
            minStack.Push(7);
            minStack.Push(3);
            minStack.Push(5);
            minStack.Push(2);
            minStack.Push(7);
            minStack.Pop();
            Assert.AreEqual(2, minStack.stack.Peek());
        }
    }
}
