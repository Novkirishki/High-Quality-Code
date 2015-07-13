using System;

namespace Task_2.Printer
{
    public static class Printer
    {
        public static void PrintStatistics(double[] data, int dataLength)
        {
            PrintMax(data, dataLength);            
            PrintMin(data, dataLength);
            PrintAverage(data, dataLength);
        } 

        private static void PrintMax(double[] data, int dataCount) 
        {
            double currentMax = data[0];
            for (int i = 1; i < dataCount; i++)
            {
                if (data[i] > currentMax)
                {
                    currentMax = data[i];
                }
            }

            Console.WriteLine("The maximum is: {0}", currentMax);
        }

        private static void PrintMin(double[] data, int dataLength)
        {
            double currentMin = data[0];
            for (int i = 1; i < dataLength; i++)
            {
                if (data[i] < currentMin)
                {
                    currentMin = data[i];
                }
            }

            Console.WriteLine("The minimum is: {0}", currentMin);
        }

        private static void PrintAverage(double[] data, int dataLength)
        {
            double sum = 0;
            for (int i = 0; i < dataLength; i++)
            {
                sum += data[i]; 
            }

            double average = sum / dataLength;
            Console.WriteLine("The average is: {0}", average);
        }
    }
}
