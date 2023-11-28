using GenericList;
using MyStack;
using NUnit.Framework;

namespace StackUnitTests
{
    public class PalindromTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Palindrom_NoPalindrom_ReturnsFalse()
        {
            Assert.IsFalse(PalindromTester.IsPalindrom("BlablB"));
        }

        [Test]
        public void Palindrom_PalindromOdd_ReturnsTrue()
        {
            Assert.IsTrue(PalindromTester.IsPalindrom("BlaZalB"));
        }

        [Test]
        public void Palindrom_PalindromEven_ReturnsTrue()
        {
            Assert.IsTrue(PalindromTester.IsPalindrom("BlaalB"));
        }

        [Test]
        public void Palindrom_EmpryString_ReturnsTrue()
        {
            Assert.IsTrue(PalindromTester.IsPalindrom(""));
        }


        [Test]
        public void PushAndPop_PushThreeTimesPoPonce_TwoElementsInStackLastOneRemoved()
        {
            MyStack.MyStack stack = new MyStack.MyStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            var last = stack.Pop();
            Assert.AreEqual(last.data, 3);
            Assert.AreEqual(stack.ToString(), "| 1 | 2 |");
        }

    }
}