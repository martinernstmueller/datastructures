﻿namespace Common
{
    public interface IMyList
    {
        void SwitchNode(Node argFirstNode, Node argSecondNode);
        void SetSortStrategy(SortStrategy sortStrategy);
        Node GetFirst();
        void Sort();
        void SortDesc();

    }
    enum SortOrder
    {
        ascending,
        descending
    }


}