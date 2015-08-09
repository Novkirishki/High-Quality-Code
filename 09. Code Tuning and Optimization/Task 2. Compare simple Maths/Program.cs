namespace Task_2.Compare_simple_Maths
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {        
            // testing addition
            Console.WriteLine("Addition");
            CalculatorSpeedTest.AddInteger(4, 5);
            CalculatorSpeedTest.AddDouble(4.34, 5.54);
            CalculatorSpeedTest.AddLong(4, 5);
            CalculatorSpeedTest.AddFloat(4, 5);
            CalculatorSpeedTest.AddDecimal(4, 5);

            // substraction
            Console.WriteLine("Substraction");
            CalculatorSpeedTest.SubstractInteger(4, 5);
            CalculatorSpeedTest.SubstractDouble(4, 5);
            CalculatorSpeedTest.SubstractLong(4, 5);
            CalculatorSpeedTest.SubstractFloat(4, 5);
            CalculatorSpeedTest.SubstractDecimal(4, 5);

            // multiplication
            Console.WriteLine("Multiplication");
            CalculatorSpeedTest.MultiplyInteger(4, 5);
            CalculatorSpeedTest.MultiplyDouble(4, 5);
            CalculatorSpeedTest.MultiplyLong(4, 5);
            CalculatorSpeedTest.MultiplyFloat(4, 5);
            CalculatorSpeedTest.MultiplyDecimal(4, 5);

            // division
            Console.WriteLine("Division");
            CalculatorSpeedTest.DivideInteger(4, 5);
            CalculatorSpeedTest.DivideDouble(4, 5);
            CalculatorSpeedTest.DivideLong(4, 5);
            CalculatorSpeedTest.DivideFloat(4, 5);
            CalculatorSpeedTest.DivideDecimal(4, 5);

            // incremention
            Console.WriteLine("Incremention");
            CalculatorSpeedTest.IncrementInteger(4, 5);
            CalculatorSpeedTest.IncrementDouble(4, 5);
            CalculatorSpeedTest.IncrementLong(4, 5);
            CalculatorSpeedTest.IncrementFloat(4, 5);
            CalculatorSpeedTest.IncrementDecimal(4, 5);
        }
    }
}