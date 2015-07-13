namespace BoolPrinter
{
    using System;

    public static class BooleanPrinter
    {
        public static void Print(bool value)
        {
            string boolAsString = value.ToString();
            Console.WriteLine(value);
        }
    }
}
