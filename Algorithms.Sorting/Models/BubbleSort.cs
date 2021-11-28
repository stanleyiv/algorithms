using System;

namespace Algorithms.Sorting.Models
{
    public class BubbleSort : ISort
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
                for (var j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        HelperMethods.Swap(arr, j, j + 1);
                    }
                }
            }
        }
    }
}
