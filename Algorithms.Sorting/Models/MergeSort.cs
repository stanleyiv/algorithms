using System;

namespace Algorithms.Sorting.Models
{
    public class MergeSort : BaseSorter
    {
        /// <summary>
        /// O(nlog(n))
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="comparer"></param>
        protected override void SortArray(int[] arr, Func<int, int, bool> comparer)
        {
            SortHelper(arr, 0, arr.Length - 1, comparer);
        }

        private void SortHelper(int[] arr, int left, int right, Func<int, int, bool> comparer)
        {
            if (left >= right) return;
            int middle = (right + left) / 2;
            SortHelper(arr, left, middle, comparer);
            SortHelper(arr, middle + 1, right, comparer);
            Merge(arr, left, middle, right, comparer);
        }

        private void Merge(int[] arr, int left, int middle, int right, Func<int, int, bool> comparer)
        {

            int[] leftArr = arr[left..(middle + 1)];
            int[] rightArr = arr[(middle + 1)..(right + 1)];
            int i = 0, j = 0, k = left;
            while (i < leftArr.Length && j < rightArr.Length)
            {
                if (comparer(leftArr[i], rightArr[j]))
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }
            while (i < leftArr.Length)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }
            while (j < rightArr.Length)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }
        }
    }
}
