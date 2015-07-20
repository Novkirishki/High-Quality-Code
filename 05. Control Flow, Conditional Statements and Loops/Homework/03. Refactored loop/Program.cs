using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Refactored_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new String[100];
            string expectedValue = "abc";
            bool isValueFound = false;

            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        isValueFound = true;
                    }
                }

                Console.WriteLine(array[i]);
            }

            if (isValueFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
