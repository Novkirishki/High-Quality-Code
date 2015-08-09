// I have not used generic methods because casting to dynamic could change measurement accuracy
namespace Task_2.Compare_simple_Maths
{
    using System;
    using System.Diagnostics;

    public static class CalculatorSpeedTest
    {
        public static void AddInteger(int firstNumber, int secondNumber)
        {
            int result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber + secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Addition of two integer numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void AddLong(long firstNumber, long secondNumber)
        {
            long result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber + secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Addition of two long numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void AddDouble(double firstNumber, double secondNumber)
        {
            double result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber + secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Addition of two double numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void AddFloat(float firstNumber, float secondNumber)
        {
            float result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber + secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Addition of two float numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void AddDecimal(decimal firstNumber, decimal secondNumber)
        {
            decimal result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber + secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Addition of two decimal numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void SubstractInteger(int firstNumber, int secondNumber)
        {
            int result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber - secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Substraction of two integer numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void SubstractLong(long firstNumber, long secondNumber)
        {
            long result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber - secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Substraction of two long numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void SubstractDouble(double firstNumber, double secondNumber)
        {
            double result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber - secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Substraction of two double numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void SubstractFloat(float firstNumber, float secondNumber)
        {
            float result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber - secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Substraction of two float numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void SubstractDecimal(decimal firstNumber, decimal secondNumber)
        {
            decimal result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber - secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Substraction of two decimal numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void MultiplyInteger(int firstNumber, int secondNumber)
        {
            int result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber * secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Multiplication of two integer numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void MultiplyLong(long firstNumber, long secondNumber)
        {
            long result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber * secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Multiplication of two long numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void MultiplyDouble(double firstNumber, double secondNumber)
        {
            double result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber * secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Multiplication of two double numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void MultiplyFloat(float firstNumber, float secondNumber)
        {
            float result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber * secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Multiplication of two float numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void MultiplyDecimal(decimal firstNumber, decimal secondNumber)
        {
            decimal result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber * secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Multiplication of two decimal numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void DivideInteger(int firstNumber, int secondNumber)
        {
            int result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber / secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Division of two integer numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void DivideLong(long firstNumber, long secondNumber)
        {
            long result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber / secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Division of two long numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void DivideDouble(double firstNumber, double secondNumber)
        {
            double result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber / secondNumber;
            }
            
            sw.Stop();
            Console.WriteLine("Division of two double numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void DivideFloat(float firstNumber, float secondNumber)
        {
            float result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber / secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Division of two float numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void DivideDecimal(decimal firstNumber, decimal secondNumber)
        {
            decimal result;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                result = firstNumber / secondNumber;
            }

            sw.Stop();
            Console.WriteLine("Division of two decimal numbers 10 mil times: {0}", sw.Elapsed);
        }

        public static void IncrementInteger(int number, int step)
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                number += step;
            }

            sw.Stop();
            Console.WriteLine("Incremention of integer number 10 mil times: {0}", sw.Elapsed);
        }

        public static void IncrementLong(long number, long step)
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                number += step;
            }

            sw.Stop();
            Console.WriteLine("Incremention of long number 10 mil times: {0}", sw.Elapsed);
        }

        public static void IncrementDouble(double number, double step)
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                number += step;
            }

            sw.Stop();
            Console.WriteLine("Incremention of double number 10 mil times: {0}", sw.Elapsed);
        }

        public static void IncrementFloat(float number, float step)
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                number += step;
            }

            sw.Stop();
            Console.WriteLine("Incremention of float number 10 mil times: {0}", sw.Elapsed);
        }

        public static void IncrementDecimal(decimal number, decimal step)
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                number += step;
            }

            sw.Stop();
            Console.WriteLine("Incremention of decimal number 10 mil times: {0}", sw.Elapsed);
        }
    }
}