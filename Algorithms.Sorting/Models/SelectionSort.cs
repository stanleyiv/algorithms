using System;

namespace Algorithms.Sorting.Models
{
    class SelectionSort : ISort
    {
        /// <summary>
        /// Sort in ascending order. Worst Case Runtime: O(n^2)
        /// </summary>
        /// <param name="arr"></param>
        public void Sort(int[] arr)
        {
            SortArr(arr, SortDirection.Ascending);
        }

        /// <summary>
        /// Sort in descending order. Worst Case Runtime: O(n^2)
        /// </summary>
        /// <param name="arr"></param>
        public void SortDesc(int[] arr)
        {
            SortArr(arr, SortDirection.Descending);
        }

        private void SortArr(int[] arr, SortDirection sortDirection = SortDirection.Ascending)
        {
            Func<int, int, bool> comparer = (x, y) => x < y;
            if (sortDirection == SortDirection.Descending) comparer = (x, y) => x > y;

            for (var i = 0; i < arr.Length; i++)
            {
                var value = arr[i];
                var index = i;
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (comparer(arr[j], value))
                    {
                        value = arr[j];
                        index = j;
                    }
                }
                if (index != i)
                {
                    Swap(arr, i, index);
                }
            }
        }

        private void Swap(int[] arr, int val1, int val2)
        {
            var temp = arr[val1];
            arr[val1] = arr[val2];
            arr[val2] = temp;
        }
    }
}
