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
        Node node1 = new Node(1);
        Node node2 = new Node(2);
        Node node3 = new Node(3);
        Node node4 = new Node(4);
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestSLLCount_AddItems_ReturnsCorrectCount()
        {
            var myLL = new SingleLinkedList();
            myLL.InsertLast(new Node(1));
            myLL.InsertLast(new Node(1));
            myLL.InsertLast(new Node(1));
            myLL.InsertLast(new Node(1));  
            Assert.AreEqual(4, myLL.count());
        }

        [Test]
        public void TestSLLCount_SwitchExistingNodes_ReturnsTrue()
        {
            var myLL = new SingleLinkedList();
            
            myLL.InsertLast(node1);
            myLL.InsertLast(node2);
            myLL.InsertLast(node3);
            myLL.InsertLast(node4);
            Assert.AreEqual(4, myLL.count());
            myLL.SwitchNode(new Node(2), new Node(3));
            Assert.AreEqual(4, myLL.count());

        }

        [Test]
        public void TestIntegerStackSize_removeItems_ReturnsCorrectStackSize()
        {
        }

    }
}
