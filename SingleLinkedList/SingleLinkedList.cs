using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class SingleLinkedList
    {
        Node first = null;
        Node last = null;
        int _count = 0;
        public void InsertLast(Node newNode)
        {
            if (first == null)
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                last.next = newNode;
                last = newNode;
            }
            _count++;
        }

        public void SwitchNode(Node argFirstNode, Node argSecondNode)
        {
            var cur = first;
            while (cur.next != null)
            {
                if (cur.data == argFirstNode.data)
                    cur.data = argSecondNode.data;
                else if (cur.data == argSecondNode.data)
                    cur.data = argFirstNode.data;
                cur = cur.next;
            }
            return;
        }

        public Node GetNode(Node argNode)
        {
            Node current = first;
            while (current.next != null)
            {
                if (current.data == argNode.data)
                    return current;
                current = current.next;
            }
            return null;
        }


        public int count()
        {
            return _count;
        } // return the number of elements in the linked list
        public override string ToString() {
            string retval = "";
            if (first == null)
                return "No elements in List";
            
            var node = first;
            while (node != null)
            {
                retval += "| " + node.data + " ";
                node = node.next;
            }
            retval += "|";
            return retval;
        }

        public void SortWithInsertionSort()
        {
            var nextNode = first.next;
            
            while (nextNode != null)
            {
                for (var cur = first; cur.next != null; cur = cur.next)
                {
                    if (cur == nextNode)
                        break;
                    if (cur.data < nextNode.data)
                        continue;
                    (cur.data, nextNode.data) = (nextNode.data, cur.data); 
                }
                nextNode = nextNode.next;
            }
        }

        public void SortInverseWithInsertionSort()
        {
            var nextNode = first.next;

            while (nextNode != null)
            {
                for (var cur = first; cur.next != null; cur = cur.next)
                {
                    if (cur == nextNode)
                        break;
                    if (cur.data > nextNode.data)
                        continue;
                    (cur.data, nextNode.data) = (nextNode.data, cur.data);
                }
                nextNode = nextNode.next;
            }
        }
    }
}
