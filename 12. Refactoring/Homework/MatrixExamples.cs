namespace MatrixOperations
{
    using System;

    /// <summary>
    /// Example for usage of the Matrix class
    /// </summary>
    public class MatrixExamples
    {
        /// <summary>
        /// The main method
        /// </summary>
        /// <param name="args">Arguments array</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number between 1 and 99");
            int n = int.Parse(Console.ReadLine());

            Matrix matrix = new Matrix(n);
            matrix.Fill();

            Console.WriteLine(matrix.ToString());
        }
    }
}
