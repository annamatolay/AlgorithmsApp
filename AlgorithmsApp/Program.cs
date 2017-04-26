using System;
using AlgorithmsApp.searching;
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
                        RunSort(Bubble.Sorting(GetArray(Convert.ToInt32(Console.ReadLine()))));
                        break;
                    case "quick":
                        Console.WriteLine("Give an array size:");
                        RunSort(Quick.Sorting(GetArray(Convert.ToInt32(Console.ReadLine()))));
                        break;
                    case "merge":
                        Console.WriteLine("Give an array size:");
                        RunSort(Merge.Sorting(GetArray(Convert.ToInt32(Console.ReadLine()))));
                        break;
                    case "search":
                        Console.WriteLine("Give an array size:");
                        var arr = GetArray(Convert.ToInt32(Console.ReadLine()), true);
                        Console.WriteLine("Give a target:");
                        Console.WriteLine(Binary.Search(arr, Convert.ToInt32(Console.ReadLine()), 0, arr.Length-1));
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

        private static int[] GetArray(int size, bool ordered = false)
        {
            var array = new int[size];
            var random = new Random();
            if (ordered)
            {
                for (var i = 0; i < array.Length; i++)
                {
                    array[i] = i + 1;
                }
            }
            else
            {
                for (var i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-100, 100);
                }
            }
            Console.WriteLine("Input: [{0}]", string.Join(", ", array));
            return array;
        }

    }
}
