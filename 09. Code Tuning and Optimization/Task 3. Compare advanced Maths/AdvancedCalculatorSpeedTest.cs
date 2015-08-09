namespace Task_3.Compare_advanced_Maths
{
    using System;
    using System.Diagnostics;

    public static class AdvancedCalculatorSpeedTest
    {
        public static void RootDouble(double number)
        {
            double result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = Math.Sqrt(number);
            }

            sw.Stop();
            Console.WriteLine("Finding square root of double number 10 mil times: {0}", sw.Elapsed);
        }

        public static void RootFloat(float number)
        {
            double result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = Math.Sqrt(number);
            }

            sw.Stop();
            Console.WriteLine("Finding square root of float number 10 mil times: {0}", sw.Elapsed);
        }

        public static void RootDecimal(decimal number)
        {
            double result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = Math.Sqrt((double)number);
            }

            sw.Stop();
            Console.WriteLine("Finding square root of decimnal number 10 mil times: {0}", sw.Elapsed);
        }

        public static void SineDouble(double number)
        {
            double result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = Math.Sin(number);
            }

            sw.Stop();
            Console.WriteLine("Finding sine of double number 10 mil times: {0}", sw.Elapsed);
        }

        public static void SineFloat(float number)
        {
            double result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = Math.Sin(number);
            }

            sw.Stop();
            Console.WriteLine("Finding sine of float number 10 mil times: {0}", sw.Elapsed);
        }

        public static void SineDecimal(decimal number)
        {
            double result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = Math.Sin((double)number);
            }

            sw.Stop();
            Console.WriteLine("Finding sine of decimnal number 10 mil times: {0}", sw.Elapsed);
        }

        public static void LogDouble(double number)
        {
            double result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = Math.Log(number);
            }

            sw.Stop();
            Console.WriteLine("Finding natural logarithm of double number 10 mil times: {0}", sw.Elapsed);
        }

        public static void LogFloat(float number)
        {
            double result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = Math.Log(number);
            }

            sw.Stop();
            Console.WriteLine("Finding natural logarithm of float number 10 mil times: {0}", sw.Elapsed);
        }

        public static void LogDecimal(decimal number)
        {
            double result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = Math.Log((double)number);
            }

            sw.Stop();
            Console.WriteLine("Finding natural logarithm of decimnal number 10 mil times: {0}", sw.Elapsed);
        }
    }
}