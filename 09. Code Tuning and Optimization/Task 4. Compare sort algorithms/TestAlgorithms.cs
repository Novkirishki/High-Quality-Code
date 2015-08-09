using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Compare_sort_algorithms
{
    public static class TestAlgorithms
    {
        public static void InsertionSortWithRandomInt() {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.InsertionSort((int[])Arrays.RandomInt.Clone());
            }

            sw.Stop();

            Console.WriteLine("Insertion sort 100 000 of array of random integers: {0}",  sw.Elapsed);
        }

        public static void InsertionSortWithOrderedInt()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.InsertionSort((int[])Arrays.SortedInt.Clone());
            }

            sw.Stop();

            Console.WriteLine("Insertion sort 100 000 of array of sorted integers: {0}", sw.Elapsed);
        }

        public static void InsertionSortWithReversedInt()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.InsertionSort((int[])Arrays.ReversedInt.Clone());
            }

            sw.Stop();

            Console.WriteLine("Insertion sort 100 000 of array of reversed integers: {0}", sw.Elapsed);
        }

        public static void InsertionSortWithRandomDouble()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.InsertionSort((double[])Arrays.RandomDouble.Clone());
            }

            sw.Stop();

            Console.WriteLine("Insertion sort 100 000 of array of random double: {0}", sw.Elapsed);
        }

        public static void InsertionSortWithOrderedDouble()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.InsertionSort((double[])Arrays.SortedDouble.Clone());
            }

            sw.Stop();

            Console.WriteLine("Insertion sort 100 000 of array of sorted double: {0}", sw.Elapsed);
        }

        public static void InsertionSortWithReversedDouble()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.InsertionSort((double[])Arrays.ReversedDouble.Clone());
            }

            sw.Stop();

            Console.WriteLine("Insertion sort 100 000 of array of reversed double: {0}", sw.Elapsed);
        }

        public static void InsertionSortWithRandomString()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.InsertionSort((string[])Arrays.RandomString.Clone());
            }

            sw.Stop();

            Console.WriteLine("Insertion sort 100 000 of array of random string: {0}", sw.Elapsed);
        }

        public static void InsertionSortWithOrderedString()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.InsertionSort((string[])Arrays.SortedString.Clone());
            }

            sw.Stop();

            Console.WriteLine("Insertion sort 100 000 of array of sorted string: {0}", sw.Elapsed);
        }

        public static void InsertionSortWithReversedString()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.InsertionSort((string[])Arrays.ReversedString.Clone());
            }

            sw.Stop();

            Console.WriteLine("Insertion sort 100 000 of array of reversed string: {0}", sw.Elapsed);
        }

        public static void SelectionSortWithRandomInt()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.SelectionSort((int[])Arrays.RandomInt.Clone());
            }

            sw.Stop();

            Console.WriteLine("Selection sort 100 000 of array of random integers: {0}", sw.Elapsed);
        }

        public static void SelectionSortWithOrderedInt()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.SelectionSort((int[])Arrays.SortedInt.Clone());
            }

            sw.Stop();

            Console.WriteLine("Selection sort 100 000 of array of sorted integers: {0}", sw.Elapsed);
        }

        public static void SelectionSortWithReversedInt()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.SelectionSort((int[])Arrays.ReversedInt.Clone());
            }

            sw.Stop();

            Console.WriteLine("Selection sort 100 000 of array of reversed integers: {0}", sw.Elapsed);
        }

        public static void SelectionSortWithRandomDouble()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.SelectionSort((double[])Arrays.RandomDouble.Clone());
            }

            sw.Stop();

            Console.WriteLine("Selection sort 100 000 of array of random double: {0}", sw.Elapsed);
        }

        public static void SelectionSortWithOrderedDouble()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.SelectionSort((double[])Arrays.SortedDouble.Clone());
            }

            sw.Stop();

            Console.WriteLine("Selection sort 100 000 of array of sorted double: {0}", sw.Elapsed);
        }

        public static void SelectionSortWithReversedDouble()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.SelectionSort((double[])Arrays.ReversedDouble.Clone());
            }

            sw.Stop();

            Console.WriteLine("Selection sort 100 000 of array of reversed double: {0}", sw.Elapsed);
        }

        public static void SelectionSortWithRandomString()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.SelectionSort((string[])Arrays.RandomString.Clone());
            }

            sw.Stop();

            Console.WriteLine("Selection sort 100 000 of array of random string: {0}", sw.Elapsed);
        }

        public static void SelectionSortWithOrderedString()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.SelectionSort((string[])Arrays.SortedString.Clone());
            }

            sw.Stop();

            Console.WriteLine("Selection sort 100 000 of array of sorted string: {0}", sw.Elapsed);
        }

        public static void SelectionSortWithReversedString()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.SelectionSort((string[])Arrays.ReversedString.Clone());
            }

            sw.Stop();

            Console.WriteLine("Selection sort 100 000 of array of reversed string: {0}", sw.Elapsed);
        }

        public static void QuickSortWithRandomInt()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.QuickSort((int[])Arrays.RandomInt.Clone(), 0, Arrays.RandomInt.Length - 1);
            }

            sw.Stop();

            Console.WriteLine("Quick sort 100 000 of array of random integers: {0}", sw.Elapsed);
        }

        public static void QuickSortWithOrderedInt()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.QuickSort((int[])Arrays.SortedInt.Clone(), 0, Arrays.SortedInt.Length - 1);
            }

            sw.Stop();

            Console.WriteLine("Quick sort 100 000 of array of sorted integers: {0}", sw.Elapsed);
        }

        public static void QuickSortWithReversedInt()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.QuickSort((int[])Arrays.ReversedInt.Clone(), 0, Arrays.ReversedInt.Length - 1);
            }

            sw.Stop();

            Console.WriteLine("Quick sort 100 000 of array of reversed integers: {0}", sw.Elapsed);
        }

        public static void QuickSortWithRandomDouble()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.QuickSort((double[])Arrays.RandomDouble.Clone(), 0, Arrays.RandomDouble.Length - 1);
            }

            sw.Stop();

            Console.WriteLine("Quick sort 100 000 of array of random double: {0}", sw.Elapsed);
        }

        public static void QuickSortWithOrderedDouble()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.QuickSort((double[])Arrays.SortedDouble.Clone(), 0, Arrays.SortedDouble.Length - 1);
            }

            sw.Stop();

            Console.WriteLine("Quick sort 100 000 of array of sorted double: {0}", sw.Elapsed);
        }

        public static void QuickSortWithReversedDouble()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.QuickSort((double[])Arrays.ReversedDouble.Clone(), 0, Arrays.ReversedDouble.Length - 1);
            }

            sw.Stop();

            Console.WriteLine("Quick sort 100 000 of array of reversed double: {0}", sw.Elapsed);
        }

        public static void QuickSortWithRandomString()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.QuickSort((string[])Arrays.RandomString.Clone(), 0, Arrays.RandomString.Length - 1);
            }

            sw.Stop();

            Console.WriteLine("Quick sort 100 000 of array of random string: {0}", sw.Elapsed);
        }

        public static void QuickSortWithOrderedString()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.QuickSort((string[])Arrays.SortedString.Clone(), 0, Arrays.SortedString.Length - 1);
            }

            sw.Stop();

            Console.WriteLine("Quick sort 100 000 of array of sorted string: {0}", sw.Elapsed);
        }

        public static void QuickSortWithReversedString()
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                Algorithms.QuickSort((string[])Arrays.ReversedString.Clone(), 0, Arrays.ReversedString.Length -1);
            }

            sw.Stop();

            Console.WriteLine("Quick sort 100 000 of array of reversed string: {0}", sw.Elapsed);
        }
    }
}
