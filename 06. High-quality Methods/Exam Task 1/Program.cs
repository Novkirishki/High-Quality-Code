// I am sorry I don't have the descripton of the tasks

namespace Exam_Task_1
{
    using System;
    using System.Text;

    public class Program
    {
        /// <summary>
        /// Finds the decimal sum of array of numbers in alphabetical numerical system
        /// </summary>
        /// <param name="numbers">Array of numbers in alphabetical numerical system</param>
        /// <param name="digits">Array of digits in the alphabetical numerical system</param>
        /// <returns>Sum in decimal</returns>
        private static long FindSumInDecimal(string[] numbers, char[] digits)
        {
            long sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int numberValue = 0;

                for (int j = 0; j < numbers[i].Length; j++)
                {
                    numberValue = Array.IndexOf(digits, numbers[i][j]) * (int)Math.Pow(19, numbers[i].Length - j - 1);
                    sum += numberValue;
                }
            }

            return sum;
        }

        /// <summary>
        /// Converts decimal number to alphabetical numerical system 
        /// </summary>
        /// <param name="numberInDecimal">Number in decimal</param>
        /// <param name="digits">Array of digits in the alphabetical numerical system</param>
        /// <returns>Number in alphabetical numerical system</returns>
        private static StringBuilder ConvertToMiau(long numberInDecimal, char[] digits)
        {
            StringBuilder numberInAlphabetical = new StringBuilder();

            do
            {
                numberInAlphabetical.Insert(0, digits[numberInDecimal % 19]);
                numberInDecimal /= 19;
            } 
            while (numberInDecimal > 0);

            return numberInAlphabetical;
        }

        private static void Main(string[] args)
        {
            // read the input and parse it
            string line = Console.ReadLine();
            string[] numbers = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            char[] digits = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                                            'l', 'm', 'n', 'o', 'p', 'q', 'r', 's'};           

            long numberInDecimal = FindSumInDecimal(numbers, digits);
            string numberInAlphabetical = ConvertToMiau(numberInDecimal, digits).ToString();

            // print the result
            Console.WriteLine("{0} = {1}", numberInAlphabetical, numberInDecimal);
        }
    }
}