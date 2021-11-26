using Algorithms.Sorting.Models;
using System;

namespace Algorithms.Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 6, 1, 3, -2, 0, 6, 7, 8, 1, 9, 11, 2, -1 };
            var selection = new SelectionSort();
            selection.Sort(arr);
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
