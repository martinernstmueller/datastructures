namespace Common
{
    public interface IMyList
    {
        void SwitchNode(Node argFirstNode, Node argSecondNode);
        void SetSortStrategy(SortStrategy sortStrategy);
        Node GetFirst();
        void Sort();
    }

    public abstract class SortStrategy
    {
        public abstract void Sort(IMyList list);
    }

    public class InsertionSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            var nextNode = list.GetFirst().next;

            while (nextNode != null)
            {
                for (var cur = list.GetFirst(); cur.next != null; cur = cur.next)
                {
                    if (cur == nextNode)
                        break;
                    if (cur.data < nextNode.data)
                        continue;
                    (cur.data, nextNode.data) = (nextNode.data, cur.data);
                }
                nextNode = nextNode.next;
            }
            Console.WriteLine("InsertionSorted list ");
        }
    }

    public class InsertionSortReverted : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            var nextNode = list.GetFirst().next;

            while (nextNode != null)
            {
                for (var cur = list.GetFirst(); cur.next != null; cur = cur.next)
                {
                    if (cur == nextNode)
                        break;
                    if (cur.data > nextNode.data)
                        continue;
                    (cur.data, nextNode.data) = (nextNode.data, cur.data);
                }
                nextNode = nextNode.next;
            }
            Console.WriteLine("InsertionSorted list ");
        }
    }

}