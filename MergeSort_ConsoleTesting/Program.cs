using System;
using System.Collections.Generic;
using MergeSortNS;

namespace MergeSort_ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> TestArrays = new List<int[]>();

            int[] array_1element = new int[1] { 5 };
            int[] array_2elements = new int[2] { 5, 2 };
            int[] array_3elements = new int[3] { 1, 5, 3 };
            int[] array_8elements_NotSorted = new int[8] { 2, 4, 1, 6, 5, 7, 8, 3 };
            int[] array_8elements_ReverseSorted = new int[8] { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] array_8elements_Sorted = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] array_8eelements_HasNegativeNumbers = new int[8] { 5, -1000, 1000, -1, 0, 1, -2, -100 };
            int[] array_1000elements = GenerateArray(1000);
            int[] array_1millionElements = GenerateArray(1000000);

            TestArrays.Add(array_1element);
            TestArrays.Add(array_2elements);
            TestArrays.Add(array_3elements);
            TestArrays.Add(array_8elements_NotSorted);
            TestArrays.Add(array_8elements_ReverseSorted);
            TestArrays.Add(array_8elements_Sorted);
            TestArrays.Add(array_8eelements_HasNegativeNumbers);
            TestArrays.Add(array_1000elements);
            TestArrays.Add(array_1millionElements);

            PrintArrays(TestArrays, "Unsorted arrays: ");

            foreach (int[] array in TestArrays)
            {
                MergeSort.Sort(array);
            }

            PrintArrays(TestArrays, "Sorted arrays: ");

            Console.ReadLine();
        }

        private static int[] GenerateArray(int n)
        {
            Random random = new Random();

            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = random.Next() - random.Next();
            }

            return result;
        }

        private static void PrintArrays(IEnumerable<int[]> arrays, string message = "Printing arrays: ")
        {
            Console.WriteLine(message);

            foreach (int[] array in arrays)
            {
                foreach (int number in array)
                {
                    Console.Write("{0} ", number);
                }

                Console.WriteLine();
            }
        }
    }
}
