using System;

namespace AlgorithmsApp.sorting
{
    public class Bubble
    {
        public static int[] Sorting(int[] array)
        {
            int swapCount = 0;
            for (var i = 0; i < array.Length - 1; i++)
            {
                for (var j = 1; j < array.Length - i; j++)
                {
                    if (array[j - 1] <= array[j]) continue;
                    var temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                    Console.WriteLine("Swap: " + array[j] + " <> " + array[j - 1] );
                    swapCount++;
                }

            }
            Console.WriteLine("Step: " + swapCount + " (number swap)");
            return array;
        }
    }
}