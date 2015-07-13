using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] testData = { 1, 2, 3, 4, 5, 6 };
            Printer.PrintStatistics(testData, 6);
        }
    }
}
