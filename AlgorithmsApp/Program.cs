using System;
using AlgorithmsApp.sorting;

namespace AlgorithmsApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome! {0} BubbleSort - bubble {0} QuickSort - quick {0} Exit is q {0} MergeSort - merge", Environment.NewLine);
//            while(true)
            for(;;)
            {
                Console.WriteLine("Give a correct operation name, please!");
                var op = Console.ReadLine();
                switch (op)
                {
                    case "q":
                        Environment.Exit(0);
                        break;
                    case "clear":
                        Console.Clear();
                        Main(args);
                        break;
                    case "bubble":
                        Console.WriteLine("Give an array size:");
                        RunSort(Bubble.Sorting(GetRandomArray(Convert.ToInt32(Console.ReadLine()))));
                        break;
                    case "quick":
                        Console.WriteLine("Give an array size:");
                        RunSort(Quick.Sorting(GetRandomArray(Convert.ToInt32(Console.ReadLine()))));
                        break;
                    case "merge":
                        Console.WriteLine("Give an array size:");
                        RunSort(Merge.Sorting(GetRandomArray(Convert.ToInt32(Console.ReadLine()))));
                        break;
                    default:
                        Console.WriteLine("Invalid operation!");
                        break;
                }
            }
        }

        private static void RunSort(int[] res)
        {
            Console.WriteLine("Output: [{0}]", string.Join(", ", res));
        }

        private static int[] GetRandomArray(int size)
        {
            var array = new int[size];
            var random = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }
            Console.WriteLine("Input: [{0}]", string.Join(", ", array));
            return array;
        }

    }
}
