using System;

namespace Algorithms.Sorting.Models
{
    public class InsertionSort : ISort
    {
        public void Sort(int[] arr)
        {
            SortAsc(arr);
        }

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
