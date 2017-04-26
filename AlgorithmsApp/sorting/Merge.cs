namespace AlgorithmsApp.sorting
{
    public class Merge
    {
        private static int[] _array;
        private static int[] _helpers;
        private static int _length;

        public static int[] Sorting(int[] array)
        {
            _array = array;
            _length = _array.Length;
            _helpers = new int[_length];
            return MergeSort(0, _length - 1);
        }

        private static int[] MergeSort(int low, int high)
        {
            if (low >= high) return _array;
            var middle = low + (high - low) / 2;
            MergeSort(low, middle);
            MergeSort(middle + 1, high);
            return Sort(low, middle, high);
        }

        private static int[] Sort(int low, int middle, int high)
        {
            for (var i = low; i <= high; i++)
            {
                _helpers[i] = _array[i];
            }

            var l = low;
            var m = middle + 1;
            var o = low;
            while (l <= middle && m <= high)
            {
                if (_helpers[l] <= _helpers[m])
                {
                    _array[o] = _helpers[l];
                    l++;
                }
                else
                {
                    _array[o] = _helpers[m];
                    m++;
                }
                o++;
            }
            while (l <= middle)
            {
                _array[o] = _helpers[l];
                o++;
                l++;
            }
            return _array;
        }
    }
}