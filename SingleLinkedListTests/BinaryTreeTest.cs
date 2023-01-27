using GenericList;
using MyStack;
using NUnit.Framework;

namespace StackUnitTests
{
    public class BinaryTreeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_OneElementToEmptyTree_SingleNode()
        {
            MyBinaryTree tree = new MyBinaryTree();
            tree.Add(1);
            var bla = tree.ToString();
            Assert.AreSame(bla, "1");
        }

        [Test]
        public void Add_SmallestElement_ElementIsInsertMostLeft()
        {
            MyBinaryTree tree = new MyBinaryTree();
            tree.Add(5);
            tree.Add(4);
            tree.Add(1);
            var bla = tree.ToString();
            Assert.AreEqual(bla, "145");
        }

        [Test]
        public void Add_BiggestElement_ElementIsInsertMostRight()
        {
            MyBinaryTree tree = new MyBinaryTree();
            tree.Add(5);
            tree.Add(4);
            tree.Add(1);
            tree.Add(6);
            var bla = tree.ToString();
            Assert.AreEqual(bla, "1456");
        }

        [Test]
        public void Add_MiddleElement_ElementIsInsertInTheMiddle()
        {
            MyBinaryTree tree = new MyBinaryTree();
            tree.Add(5);
            tree.Add(4);
            tree.Add(1);
            tree.Add(6);
            tree.Add(3);
            var bla = tree.ToString();
            Assert.AreEqual(bla, "13456");
        }


        [Test]
        public void delete_MiddleElement_ElementIsDeleted()
        {
            MyBinaryTree tree = new MyBinaryTree();
            tree.Add(5);
            tree.Add(4);
            tree.Add(1);
            tree.Add(6);
            tree.Add(3);
            var bla = tree.ToString();
            Assert.AreEqual(bla, "13456");
            tree.Delete(4);
            bla = tree.ToString();
        }

        [Test]
        public void delete_Root_ElementIsDeleted()
        {
            MyBinaryTree tree = new MyBinaryTree();
            tree.Add(5);
            tree.Add(4);
            tree.Add(1);
            tree.Add(6);
            tree.Add(3);
            var bla = tree.ToString();
            Assert.AreEqual(bla, "13456");
            tree.Delete(5);
            bla = tree.ToString();
        }

    }
}