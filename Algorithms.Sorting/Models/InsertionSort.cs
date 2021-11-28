using System;

namespace Algorithms.Sorting.Models
{
    public class InsertionSort : BaseSorter
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
                var j = i;
                while (j > 0 && comparer(arr[j], arr[j - 1]))
                {
                    HelperMethods.Swap(arr, j - 1, j);
                    j--;
                }
            }
        }
    }
}
