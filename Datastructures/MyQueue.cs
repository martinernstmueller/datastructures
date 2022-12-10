using Common;
using GenericList;

namespace MyStack
{
    public class MyQueue
    {
        private SingleLinkedList internalList = new SingleLinkedList();

        public Node Enqueue(int argValue)
        {
            var nodeToAdd = new Node(argValue);
            internalList.InsertLast(nodeToAdd);
            return nodeToAdd; 
        }

        public Node Dequeue()
        {
            var retval = internalList.GetFirst();
            internalList.RemoveFirstElement();
            return retval;
        }

        public override string ToString()
        {   
            return internalList.ToString();
        }

    }
}