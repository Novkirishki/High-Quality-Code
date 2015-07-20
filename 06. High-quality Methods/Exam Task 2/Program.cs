namespace Exam_Task_2
{
    using System;
    using System.Numerics;

    public class Program
    {
        /// <summary>
        /// Parses string array of numbers to integer array
        /// </summary>
        /// <param name="numbersAsStrings">Numbers as strings</param>
        /// <returns>Numbers as integers</returns>
        private static int[] ParseToInt(string[] numbersAsStrings)
        {
            int[] numbers = new int[numbersAsStrings.Length];

            for (int i = 0; i < numbersAsStrings.Length; i++)
            {
                numbers[i] = int.Parse(numbersAsStrings[i]);
            }

            return numbers;
        }

        /// <summary>
        /// Finds the sum of odd absolute differences of adjacent elements of array
        /// </summary>
        /// <param name="numbers">Array of integers</param>
        /// <returns>The sum of odd absolute differences of adjacent elements</returns>
        private static BigInteger FindSumOfOddAbsoluteDifferences(int[] numbers)
        {
            BigInteger sum = 0;

            for (int index = 1; index < numbers.Length; index++)
            {
                long absoluteDifference = Math.Abs(numbers[index] - numbers[index - 1]);

                if (absoluteDifference % 2 == 0)
                {
                    ++index;
                }
                else
                {
                    sum += absoluteDifference;
                }
            }

            return sum;
        }

        private static void Main(string[] args)
        {
            // read the input and parse it
            string line = Console.ReadLine();
            string[] numbersAsStrings = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = ParseToInt(numbersAsStrings);

            BigInteger sum = FindSumOfOddAbsoluteDifferences(numbers);

            // print the result
            Console.WriteLine(sum);
        }
    }
}