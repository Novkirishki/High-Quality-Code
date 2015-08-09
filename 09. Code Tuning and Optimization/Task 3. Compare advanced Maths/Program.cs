namespace Task_3.Compare_advanced_Maths
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Measuring square root speed");
            AdvancedCalculatorSpeedTest.RootDouble(36);
            AdvancedCalculatorSpeedTest.RootFloat(36);
            AdvancedCalculatorSpeedTest.RootDecimal(36);

            Console.WriteLine("Measuring sine speed");
            AdvancedCalculatorSpeedTest.SineDouble(36);
            AdvancedCalculatorSpeedTest.SineFloat(36);
            AdvancedCalculatorSpeedTest.SineDecimal(36);

            Console.WriteLine("Measuring natural log speed");
            AdvancedCalculatorSpeedTest.LogDouble(36);
            AdvancedCalculatorSpeedTest.LogFloat(36);
            AdvancedCalculatorSpeedTest.LogDecimal(36);
        }
    }
}