//Description is here http://bgcoder.com/Contests/Practice/Index/205#3

using System;
using System.Numerics;

namespace _04.Exam_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = 0;
            long currentNumber;
            BigInteger finalResult = 1;
            BigInteger finalResultForTheFirstTen = 0;

            //read the first line
            string line = Console.ReadLine();

            while(line != "END")
            {
                currentNumber = long.Parse(line);

                if (numberCount % 2 == 0)
                {
                    //If the numbers are more than 10, save the result and start again
                    if (numberCount == 10)
                    {
                        finalResultForTheFirstTen = finalResult;
                        finalResult = 1;
                    }

                    finalResult *= FindDigitsProduct(currentNumber);
                }

                line = Console.ReadLine();
                numberCount++;
            }

            //print result
            if (finalResultForTheFirstTen != 0)
            {
                Console.WriteLine(finalResultForTheFirstTen);
            }

            Console.WriteLine(finalResult);
        }

        private static BigInteger FindDigitsProduct(long number)
        {
            BigInteger product = 1;
            long digit;

            while(number > 0)
            {
                digit = number % 10;

                if (digit != 0)
                {
                    product *= digit;
                }

                number /= 10;
            }

            return product;
        }
    }
}
