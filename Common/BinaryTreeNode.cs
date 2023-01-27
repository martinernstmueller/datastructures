using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class BinaryTreeNode
    {
        public int data;
        public BinaryTreeNode LeftChild;
        public BinaryTreeNode RightChild;
        // Constructor to create a new node
        public BinaryTreeNode(int argData) { data = argData; }
        public bool IsLeaf()
        {
            return LeftChild == null && RightChild == null;
        }
        public override string ToString()
        {
            return data.ToString();
        }
    }

}
