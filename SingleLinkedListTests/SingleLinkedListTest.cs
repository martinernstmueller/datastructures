using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericList;

namespace TestProject1
{
    public class SingleLinkedListTest
    {
        SingleLinkedList mySLL = new SingleLinkedList();
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestSLLCount_AddItems_ReturnsCorrectCount()
        {
            var myLL = new SingleLinkedList();
            myLL.insert(new Node(1));
            myLL.insert(new Node(1));
            myLL.insert(new Node(1));
            myLL.insert(new Node(1)); 
            Assert.AreEqual(4, myLL.count());
        }

        [Test]
        public void TestIntegerStackSize_removeItems_ReturnsCorrectStackSize()
        {
        }

    }
}
