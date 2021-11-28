using Algorithms.Sorting.Models;
using System;

namespace Algorithms.Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var arr = new int[100];
            for (var i = 0; i < 100; i++)
            {
                var num = rand.Next(101);
                if (i % 2 == 1) arr[i] = num * -1;
                else arr[i] = num;
            }
            var sorter = new MergeSort();
            sorter.Sort(arr);
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
