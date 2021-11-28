namespace Algorithms.Sorting
{
    public static class HelperMethods
    {
        public static void Swap(int[] arr, int val1, int val2)
        {
            var temp = arr[val1];
            arr[val1] = arr[val2];
            arr[val2] = temp;
        }
    }
}
