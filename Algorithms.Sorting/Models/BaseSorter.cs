using System;

namespace Algorithms.Sorting.Models
{
    public abstract class BaseSorter : ISort
    {
        public void Sort(int[] arr)
        {
            static bool comparer(int x, int y) => x < y;
            SortArray(arr, comparer);
        }

        public void SortDesc(int[] arr)
        {
            static bool comparer(int x, int y) => x > y;
            SortArray(arr, comparer);
        }

        protected abstract void SortArray(int[] arr, Func<int, int, bool> comparer);
    }
}
