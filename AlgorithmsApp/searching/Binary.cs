namespace AlgorithmsApp.searching
{
    public class Binary
    {
        public static int Search(int[] array, int target, int start, int end)
        {
            if (start > end)
            {
                return -1;
            }
            var middle = (start + end) / 2;
            var value = array[middle];
            if (value == target)
            {
                return middle;
            }
            int next = middle + (value < target ? 1 : -1);
            return Search(array, target, next, end);
        }
    }
}