using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using AlgorithmsApp.searching;
using AlgorithmsApp.sorting;

namespace AlgorithmsApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var menu = new Dictionary<string, string>
            {
                {"-------","-------"},
                {"BubbleSort -", " b"},
                {"QuickSort -", " q"},
                {"MergeSort -", " m"},
                {"Binary Search -", " s"},
                {"------","------"},
                {"Clear -", " c"},
                {"Exit -", " e"}
            };
            Console.WriteLine("Welcome to AlgorithmsApp!");
            foreach (var item in menu)
            {
                Console.WriteLine(item.Key + item.Value);
            }
//            while(true)
            for(;;)
            {
                Console.WriteLine("Give a correct operations, please!");
                var op = Console.ReadLine();
                try
                {
                    switch (op)
                    {
                        case "e":
                            Environment.Exit(0);
                            break;
                        case "c":
                            Console.Clear();
                            Main(args);
                            break;
                        // ask a number, convert  to int32, get the array and do algorithm
                        case "b":
                            Console.WriteLine("Give an array size:");
                            WriteConsole(Bubble.Sorting(GetArray(Convert.ToInt32(Console.ReadLine()))));
                            break;
                        case "q":
                            Console.WriteLine("Give an array size:");
                            var a = GetArray(Convert.ToInt32(Console.ReadLine()));
//                            Stopwatch is here due TraceOptions the recursivity of the method
                            var watch = System.Diagnostics.Stopwatch.StartNew();
                            WriteConsole(Quick.Sorting(a));
                            watch.Stop();
                            Console.WriteLine(watch.ElapsedMilliseconds + " ms");
                            break;
                        case "m":
                            Console.WriteLine("Give an array size:");
                            WriteConsole(Merge.Sorting(GetArray(Convert.ToInt32(Console.ReadLine()))));
                            break;
                        case "s":
                            Console.WriteLine("Give an array size:");
                            var arr = GetArray(Convert.ToInt32(Console.ReadLine()), true);
                            Console.WriteLine("Give a target:");
                            Console.WriteLine(
                                Binary.Search(arr, Convert.ToInt32(Console.ReadLine()), 0, arr.Length - 1));
                            break;
                        default:
                            Console.WriteLine("Invalid operation!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input!");
                }
                catch (NullReferenceException)
                {
                    // see GetArray
                    Console.WriteLine("Invalid array size! (Choose 2 or more)");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private static int[] GetArray(int size, bool ordered = false)
        {
            if (size < 0) {size = 0;}

            var array = new int[size];
            if (ordered)
            {
                for (var i = 0; i < array.Length; i++)
                {
                    array[i] = i + 1;
                }
            }
            else
            {
                var random = new Random();
                for (var i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-100, 100);
                }
            }
            WriteConsole(array, "Input");
            return array;
        }

        private static void WriteConsole(int[] arr, string option = "Output")
        {
            Console.WriteLine(option + ": [{0}]", string.Join(", ", arr));
        }

    }
}
