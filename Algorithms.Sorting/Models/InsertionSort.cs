using System;

namespace Algorithms.Sorting.Models
{
    public class InsertionSort : ISort
    {
        /// <summary>
        /// Sort in ascending order. Worst Case Runtime: O(n^2)
        /// </summary>
        /// <param name="arr"></param>
        public void Sort(int[] arr)
        {
            SortAsc(arr);
        }

        /// <summary>
        /// Sort in descending order. Worst Case Runtime: O(n^2)
        /// </summary>
        /// <param name="arr"></param>
        public void SortDesc(int[] arr)
        {
            throw new NotImplementedException();
        }

        private void SortAsc(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                var j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    HelperMethods.Swap(arr, j - 1, j);
                    j--;
                }
            }
        }
    }
}
