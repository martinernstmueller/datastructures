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
        public void insert(Node newNode)
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
    }
}
