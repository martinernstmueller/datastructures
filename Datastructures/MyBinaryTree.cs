using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class MyBinaryTree 
    {
        public BinaryTreeNode Root { get; set; }
        public bool Add(int value)
        {
            BinaryTreeNode before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value < after.data) //Is new node in left tree? 
                    after = after.LeftChild;
                else if (value > after.data) //Is new node in right tree?
                    after = after.RightChild;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            BinaryTreeNode newNode = new(value);
            
            if (this.Root == null)//Tree is empty
                this.Root = newNode;
            else
            {
                if (value < before.data)
                    before.LeftChild = newNode;
                else
                    before.RightChild = newNode;
            }

            return true;
        }

        public (BinaryTreeNode, BinaryTreeNode) getNode(BinaryTreeNode parent, BinaryTreeNode element, int value)
        {
            if (element == null)
                return (parent, null);
            if (value == element.data)
                return (parent, element);

            (BinaryTreeNode, BinaryTreeNode)  el = (parent, null);
            if (element.RightChild != null)
                el = getNode(element, element.RightChild, value);
            if (el.Item2 == null)
                el = getNode(element, element.LeftChild, value);
            return el;
        }

        public bool Delete(int value)
        {
            var el = getNode(null, this.Root, value);
            if (el.Item2 == null)
                return false;
            
            if (el.Item2.IsLeaf())
            {
                if (el.Item1.LeftChild == el.Item2)
                    el.Item1.LeftChild = null;
                if (el.Item1.RightChild == el.Item2)
                    el.Item1.RightChild = null;
            }
            else if (el.Item2.RightChild == null)
            {
                // it not a leaf... the right child is null... so the left
                // child must not be null... replace the the node of the parent
                // with the left child...
                if (el.Item1.LeftChild == el.Item2)
                    el.Item1.LeftChild = el.Item2.LeftChild;
                if (el.Item1.RightChild == el.Item2)
                    el.Item1.RightChild = el.Item2.LeftChild;

            }
            else
            {
                // it not a leaf... the right child is not null... so the left
                // child must be null... so replace the the node of the parent
                // with the right child...
                if (el.Item1.LeftChild == el.Item2)
                    el.Item1.LeftChild = el.Item2.RightChild;
                if (el.Item1.RightChild == el.Item2)
                    el.Item1.RightChild = el.Item2.RightChild;
            }

            return true;
        }

        public override string ToString()
        {
            return getElementsAsString(Root);
        }
        string getElementsAsString(BinaryTreeNode element)
        {
            if (element == null)
                return "";
            if (element.IsLeaf())
                return element.ToString();
            return getElementsAsString(element.LeftChild) 
                + element.ToString()
                +getElementsAsString(element.RightChild);
           
        }
    }
}
