//Description is here http://bgcoder.com/Contests/Practice/Index/205#1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Exam_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading input
            var secret = int.Parse(Console.ReadLine());
            var text = Console.ReadLine();

            Encode(secret, text);
        }

        private static void Encode(int secret, string text)
        {
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(text);
            double encodedValue = 0;

            for (int index = 0; index < text.Length; index++)
            {
                int currentSymbolValue = ASCIIValues[index];

                //check if char is a letter, multiply its char code by the given SECRET and	add	1000
                bool isUppecaseLetter = (currentSymbolValue >= 65 && currentSymbolValue <= 90);
                bool isLowercaseLetter = (currentSymbolValue >= 97 && currentSymbolValue <= 122);
                if (isUppecaseLetter || isLowercaseLetter)
                {
                    encodedValue = currentSymbolValue * secret + 1000;
                }
                else if (currentSymbolValue >= 48 && currentSymbolValue <= 57)  //if the char is digit, add secret and add 500
                {
                    encodedValue = currentSymbolValue + secret + 500;
                }
                else if (currentSymbolValue == 64)
                {
                    break;
                }
                else //If the character	in	the	text is	not	a digit, letter	or	“@” (any other symbol),	subtract from its char code	SECRET
                {
                    encodedValue = currentSymbolValue - secret;
                }

                //If the character is on even position in the text - divide the encoded value by 100 and	
                //round	the	precision to 2 digits after the	decimal	point
                if (index % 2 == 0)
                {
                    encodedValue /= 100;
                    Console.WriteLine("{0:F2}", encodedValue);
                }
                else //else multiply by 100
                {
                    encodedValue *= 100;
                    Console.WriteLine(encodedValue);
                }
            }
        }
    }
}
