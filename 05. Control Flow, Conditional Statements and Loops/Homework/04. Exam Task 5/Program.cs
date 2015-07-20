//Description is here http://bgcoder.com/Contests/Practice/Index/205#4

using System;

namespace _04.Exam_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //read input data
            int numberToTakeBitsFrom = int.Parse(Console.ReadLine());
            int numbersCount = int.Parse(Console.ReadLine());

            int ocurrencesCount = 0;

            //extract 5 righmoust bits from numberToTakeBitsFrom
            int mask = (1 << 5) - 1; //..0011111
            int numberWithExtractedBits = numberToTakeBitsFrom & mask;
            string bits = Convert.ToString(numberWithExtractedBits, 2);

            for (int i = 0; i < numbersCount; i++)
            {
                //read the number
                int numberToSearchIn = int.Parse(Console.ReadLine());

                for (int j = 0; j < 25; j++)
			    {
                    //take numberToSearchIn 5 rightmoust bits and compare them
                    string bitsToCompare = Convert.ToString(numberToSearchIn & mask, 2);

                    if (bits == bitsToCompare)
                    {
                        ocurrencesCount++;
                    }

                    //shift the number to right with 1 bit
                    numberToSearchIn = numberToSearchIn >> 1;
                }
            }

            //print result
            Console.WriteLine(ocurrencesCount);
        }

    }
}
