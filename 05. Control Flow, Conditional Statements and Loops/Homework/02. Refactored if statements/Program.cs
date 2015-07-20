using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Refactored_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //First if statement 
            Potato potato = new Potato();

            if (potato != null)
            {
                bool isPeeled = potato.isPeeled;
                bool isNotRotten = !potato.isRotten;

                if (isPeeled && isNotRotten)
	            {
		            Cook(potato);
	            }
            }

            //------------------------------------------
            //Second if statement
            int x = 3,
                y = 5;
            const int MIN_X = 0, 
                      MAX_X = 10, 
                      MAX_Y = 0, 
                      MIN_Y = 10;
            bool canVisitCell = true;
            bool isInRange = IsInRange(x, MIN_X, MAX_X, y, MIN_Y, MAX_Y);

            if (isInRange && canVisitCell)
            {
               VisitCell();
            }
        }

        private static bool IsInRange(int x,int MIN_X,int MAX_X,int y,int MIN_Y,int MAX_Y)
        {
            bool isXinRange = false;

            if (MIN_X <= x && x <= MAX_X)
            {
                isXinRange = true;
            }

            bool isYinRange = false;

            if (MIN_Y <=y && y <= MAX_Y)
            {
                isYinRange = true;
            }

            return (isXinRange && isYinRange);
        }

        private static void VisitCell()
        {
            //...
        }

        private static void Cook(Potato potato)
        {
            //...
        }
    }
}
