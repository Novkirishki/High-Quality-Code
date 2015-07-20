//Description is here http://bgcoder.com/Contests/Practice/Index/205#0
using System;

namespace _04.Exam_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input three numbers: ");

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            FindBiggestOfThreeNumbers(number1, number2, number3);
            FindSmallestOfThreeNumbers(number1, number2, number3);
            FindAverageOfThreeNumbers(number1, number2, number3);
        }

        private static void FindBiggestOfThreeNumbers(int num1, int num2, int num3)
        {
            var biggestNumber = 0;

            if (num1 >= num2 && num1 >= num3)
	        {
                biggestNumber = num1;
	        }
            else if (num2 >= num3)
            {
                biggestNumber = num2;
            }
            else
            {
                biggestNumber = num3;
            }

            Console.WriteLine("The biggest number is: {0}", biggestNumber);
        }

        private static void FindSmallestOfThreeNumbers(int num1, int num2, int num3)
        {
            var smallestNumber = 0;

            if (num1 <= num2 && num1 <= num3)
            {
                smallestNumber = num1;
            }
            else if (num2 <= num3)
            {
                smallestNumber = num2;
            }
            else
            {
                smallestNumber = num3;
            }

            Console.WriteLine("The biggest number is: {0}", smallestNumber);
        }

        private static void FindAverageOfThreeNumbers(int num1, int num2, int num3)
        {
            double sum = num1 + num2 + num3;
            var average = sum / 3;

            Console.WriteLine("The average of the numbers is: {0:F3}", average);
        }
    }
}
