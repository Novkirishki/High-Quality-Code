namespace Methods
{
    using System;

    class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Triangle sides must be positive");
            }
            else if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                throw new ArgumentException("Trtiangle with such sides does not exist");
            }

            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        static string DigitToString(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Number is not a digit");
            }
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("No parameters");
            }

            int maxElement = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        static void PrintNumberFormated(double number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
            else
            {
                throw new ArgumentException("Invalid format");
            }
        }

        static double CalcDistanceBetweenPoints(double pointAx, double pointAy, double pointBx, double pointBy)
        {
            double distance = Math.Sqrt(Math.Pow(pointBx - pointAx, 2) + Math.Pow(pointBy - pointAy, 2));
            return distance;
        }

        static bool IsLineHorizontal(double pointAx, double pointAy, double pointBx, double pointBy)
        {
            return pointAx == pointBx;
        }

        static bool IsLineVertical(double pointAx, double pointAy, double pointBx, double pointBy)
        {
            return pointAy == pointBy;
        }

        static void Main()
        {
            // testing method 1
            // should return 6
            try
            {
                Console.WriteLine(CalcTriangleArea(3, 4, 5));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // should throw
            try
            {
                Console.WriteLine(CalcTriangleArea(-3, 4, 5));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // should throw
            try
            {
                Console.WriteLine(CalcTriangleArea(100, 4, 5));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }          

            // testing method 2
            // should return 5
            try
            {
                Console.WriteLine(DigitToString(5));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // should throw
            try
            {
                Console.WriteLine(DigitToString(12));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // testing method 3
            // should return 14
            try
            {
                Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // should throw
            try
            {
                Console.WriteLine(FindMax(null));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // should throw
            try
            {
                Console.WriteLine(FindMax());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // testing method 4
            // should print 1,30
            try
            {
                PrintNumberFormated(1.3, "f");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // should print 0,75 %
            try
            {
                PrintNumberFormated(0.75, "%");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // should print "        2,3"
            try
            {
                PrintNumberFormated(2.30, "r");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // should throw
            try
            {
                PrintNumberFormated(20, "h");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // testing methods 5,6,7
            Console.WriteLine(CalcDistanceBetweenPoints(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + IsLineHorizontal(3, -1, 3, 2.5));
            Console.WriteLine("Vertical? " + IsLineVertical(3, -1, 3, 2.5));

            // testing Student
            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov", Birthdate = "17.03.1992" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova", Birthdate = "03.11.1993" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine(
                "{0} older than {1} -> {2}",
                peter.FirstName, 
                stella.FirstName, 
                peter.IsOlderThan(stella));
        }
    }
}
