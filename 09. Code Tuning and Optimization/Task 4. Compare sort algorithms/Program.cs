using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Compare_sort_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertion sort");
            TestAlgorithms.InsertionSortWithRandomInt();
            TestAlgorithms.InsertionSortWithOrderedInt();
            TestAlgorithms.InsertionSortWithReversedInt();
            TestAlgorithms.InsertionSortWithRandomDouble();
            TestAlgorithms.InsertionSortWithOrderedDouble();
            TestAlgorithms.InsertionSortWithReversedDouble();
            TestAlgorithms.InsertionSortWithRandomString();
            TestAlgorithms.InsertionSortWithOrderedString();
            TestAlgorithms.InsertionSortWithReversedString();

            Console.WriteLine("Selection sort");
            TestAlgorithms.SelectionSortWithRandomInt();
            TestAlgorithms.SelectionSortWithOrderedInt();
            TestAlgorithms.SelectionSortWithReversedInt();
            TestAlgorithms.SelectionSortWithRandomDouble();
            TestAlgorithms.SelectionSortWithOrderedDouble();
            TestAlgorithms.SelectionSortWithReversedDouble();
            TestAlgorithms.SelectionSortWithRandomString();
            TestAlgorithms.SelectionSortWithOrderedString();
            TestAlgorithms.SelectionSortWithReversedString();

            Console.WriteLine("Quick sort");
            TestAlgorithms.QuickSortWithRandomInt();
            TestAlgorithms.QuickSortWithOrderedInt();
            TestAlgorithms.QuickSortWithReversedInt();
            TestAlgorithms.QuickSortWithRandomDouble();
            TestAlgorithms.QuickSortWithOrderedDouble();
            TestAlgorithms.QuickSortWithReversedDouble();
            TestAlgorithms.QuickSortWithRandomString();
            TestAlgorithms.QuickSortWithOrderedString();
            TestAlgorithms.QuickSortWithReversedString();
        }        
    }
}
