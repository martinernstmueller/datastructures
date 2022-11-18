using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class BubbleSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            var nextNode = list.GetFirst().next;
            var switched = true;
            while (switched)
            {
                switched = false;
                for (var cur = list.GetFirst(); cur.next != null; cur = cur.next)
                {
                    if (cur.data > cur.next.data)
                    {
                        (cur.data, cur.next.data) = (cur.next.data, cur.data);
                        switched = true;
                    } 
                }
            }
            Console.WriteLine("BubbleSorted list: " + list);
        }
    }
}
