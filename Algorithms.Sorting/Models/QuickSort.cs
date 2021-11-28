using System;

namespace Algorithms.Sorting.Models
{
    public class QuickSort : BaseSorter
    {
        /// <summary>
        /// Worst: O(n^2)
        /// Average: O(nlog(n))
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="comparer"></param>
        protected override void SortArray(int[] arr, Func<int, int, bool> comparer)
        {
            SortHelper(arr, 0, arr.Length - 1, comparer);
        }

        private void SortHelper(int[] arr, int low, int high, Func<int, int, bool> comparer)
        {
            if (low >= high) return;
            int pivotIdx = Partition(arr, low, high, comparer);
            SortHelper(arr, low, pivotIdx - 1, comparer);
            SortHelper(arr, pivotIdx + 1, high, comparer);
        }

        private int Partition(int[] arr, int low, int high, Func<int, int, bool> comparer)
        {
            int pivot = arr[high];
            int i = low;
            for (int j = low; j < high; j++)
            {
                if (comparer(arr[j], pivot))
                {
                    HelperMethods.Swap(arr, i, j);
                    i++;
                }
            }
            HelperMethods.Swap(arr, i, high);
            return i;
        }
    }
}
