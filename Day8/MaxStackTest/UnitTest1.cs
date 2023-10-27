using MaxStack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MaxStackTest
{
    [TestClass]
    public class GenericMaxStackTest
    {
        [TestMethod]
        public void intMaxTest()
        {
            GenericMaxStack<int> intstack = new GenericMaxStack<int>();
            intstack.Push(2);
            intstack.Push(1);
            intstack.Push(2);
            intstack.Push(5);
            Assert.AreEqual(5, intstack.Max());
            intstack.Pop();
            Assert.AreEqual(2, intstack.Max());
        }
        [TestMethod]

        public void doubleMaxTest()
        {
            GenericMaxStack<double> doubleStack = new GenericMaxStack<double>();
            doubleStack.Push(49.75);
            doubleStack.Push(23.54);
            doubleStack.Push(100.00);
            doubleStack.Pop();
            Assert.AreEqual(49.75, doubleStack.Max());
        }

        [TestMethod]

        public void stringMaxTest()
        {
            GenericMaxStack<string> stringStack = new GenericMaxStack<string>();
            stringStack.Push("OOC is bad");
            stringStack.Push("Nothing to understand");
            stringStack.Push("Try hard");
            Assert.AreEqual("Try hard", stringStack.Max());
        }
        }
    }

