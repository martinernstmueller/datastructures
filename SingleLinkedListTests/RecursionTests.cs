using GenericList;
using MyStack;
using NUnit.Framework;
using System.Diagnostics;

namespace StackUnitTests
{
    public class RecursionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum_FixNumber_ReturnsCorrectSum()
        {
            MySum ms = new MySum();
            var sumRec = ms.SumUpValues_Recursive(10);
            Assert.AreEqual(ms.SumUpValues_Iterative(5), ms.SumUpValues_Recursive(5));
        }

        private class MySum
        {
            public int SumUpValues_Iterative(int number)
            {
                var ret = 0;
                for (int i = 1; i <= number; i++)
                    ret += i;
                return ret;
            }

            public int SumUpValues_Recursiv_LM(int number)
            {
                if (number == 0)
                {
                    return 1;
                }
                Debug.WriteLine(number);
                return number * SumUpValues_Recursiv_LM(number - 1);
            }

            public int SumUpValues_Recursive_PJ(int number)
            {
                int ret = 0;
                int i = 0;
                i++;
                ret += i;
                if (i < number)
                {
                    SumUpValues_Recursive_PJ(number);
                }
                return ret;
            }

            public int SumUpValues_Recursive(int number)
            {
                if (number == 1)
                {
                    return number;
                }
                return number + SumUpValues_Recursive(number - 1);
            }
        }

    }
}