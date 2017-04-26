namespace AlgorithmsApp.searching
{
    public class Binary
    {
        public static int Search(int[] array, int target, int start, int end)
        {
            if (start > end)
                return -1;
            var midle = (start + end) / 2;
            var value = array[midle];
            if (value > target)
                return Search(array, target, start, midle-1);
            if (value < target)
                return Search(array, target, midle + 1, end);
            return midle;
        }
    }
}