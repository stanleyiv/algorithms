namespace Algorithms.Sorting.Models
{
    public interface ISort
    {
        void Sort(int[] arr);
        void SortDesc(int[] arr);
    }

    public enum SortDirection
    {
        Ascending = 0,
        Descending = 1
    }
}
