using System;

namespace Algorithms.Sorting.Models
{
    public class BubbleSort : BaseSorter
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
                for (var j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (comparer(arr[j + 1], arr[j]))
                    {
                        HelperMethods.Swap(arr, j, j + 1);
                    }
                }
            }
        }
    }
}
