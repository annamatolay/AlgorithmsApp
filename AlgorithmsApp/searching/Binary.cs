namespace AlgorithmsApp.searching
{
    public class Binary
    {
        public static int Search(int[] array, int target, int start, int end)
        {
            if (start > end)
                return -1;
            var middle = (start + end) / 2;
            var value = array[middle];
            if (value > target)
                return Search(array, target, start, middle-1);
            return value < target ? Search(array, target, middle + 1, end) : middle;
        }
    }
}