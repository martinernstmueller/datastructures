using Common;
using Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class SortAlghGenerator
    {
        public static SortStrategy GetSortAlgorithm(string Algorithm)
        {
            switch (Algorithm)
            {
                case "BubbleSort":
                    return new BubbleSort();
                case "InsertionSort":
                    return new InsertionSort();
                case "SelectionSort":
                    return new SelectionSort();
                case "InsertionSortReverted":
                    return new InsertionSortReverted();
            }
            return null;
                
        }

    }
}
