using System;

namespace Algorithms.Sorting.Models
{
    public class SelectionSort : BaseSorter
    {
        /// <summary>
        /// O(n^2)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="comparer"></param>
        protected override void SortArray(int[] arr, Func<int, int, bool> comparer)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                var index = i;
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (comparer(arr[j], arr[index]))
                    {
                        index = j;
                    }
                }
                if (index != i)
                {
                    HelperMethods.Swap(arr, i, index);
                }
            }
        }
    }
}
