using System;

namespace Algorithms.Sorting.Models
{
    public abstract class BaseSorter : ISort
    {
        public void Sort(int[] arr)
        {
            Func<int, int, bool> comparer = (x, y) => x < y;
            SortArray(arr, comparer);
        }

        public void SortDesc(int[] arr)
        {
            Func<int, int, bool> comparer = (x, y) => x > y;
            SortArray(arr, comparer);
        }

        protected abstract void SortArray(int[] arr, Func<int, int, bool> comparer);
    }
}
