using System;

namespace AlgorithmsApp.sorting
{
    public class Quick
    {
        public static int[] Sorting(int[] array, int low = 0, int high = 0)
        {
            if (low==0 && high == 0)
                return Sorting(array, 0, array.Length-1);

            int i = low, j = high;
            var pivot = array[low + (high-low)/2];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i > j) continue;
                var temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
            // Recursion
            if (low < j)
                Sorting(array, low, j);
            if (i < high)
                Sorting(array, i, high);
            return array;
        }
    }
}