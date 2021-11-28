using Algorithms.Sorting.Models;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Sorting.Tests
{
    public class InsertionSortTests
    {
        [Fact]
        public void InsertionSort_ShouldSortValues_InAscendingOrder_HappyPath()
        {
            var arr = new int[] { 6, 1, 3, -2, 0, 6, 7, 8, 1, 9, 11, 2, -1 };
            var expected = new List<int>(arr);
            expected.Sort();

            (new InsertionSort()).Sort(arr);

            arr.Should().Equal(expected.ToArray());
        }
    }
}
