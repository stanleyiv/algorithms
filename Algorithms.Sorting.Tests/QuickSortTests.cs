using Algorithms.Sorting.Models;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Algorithms.Sorting.Tests
{
    public class QuickSortTests
    {
        private readonly QuickSort _target;

        public QuickSortTests()
        {
            _target = new QuickSort();
        }

        [Fact]
        public void SortDesc_ShouldSortValues_InAscendingOrder_HappyPath()
        {
            var arr = new int[] { 6, 1, 3, -2, 0, 6, 7, 8, 1, 9, 11, 2, -1 };
            var expected = (new List<int>(arr)).OrderBy(x => x);

            _target.Sort(arr);

            arr.Should().Equal(expected.ToArray());
        }

        [Fact]
        public void SortDesc_ShouldSortValues_InDescendingOrder_HappyPath()
        {
            var arr = new int[] { 6, 1, 3, -2, 0, 6, 7, 8, 1, 9, 11, 2, -1 };
            var expected = (new List<int>(arr)).OrderByDescending(x => x);

            _target.SortDesc(arr);

            arr.Should().Equal(expected.ToArray());
        }
    }
}
