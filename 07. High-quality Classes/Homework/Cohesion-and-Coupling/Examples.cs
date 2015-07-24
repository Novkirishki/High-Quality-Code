namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// Class for showing examples
    /// </summary>
    public class Examples
    {
        /// <summary>
        /// Method for testing other classes
        /// </summary>
        public static void Main()
        {
            Console.WriteLine(FileNameExtractor.GetFileExtension("example"));
            Console.WriteLine(FileNameExtractor.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameExtractor.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileNameExtractor.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameExtractor.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameExtractor.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine(
                "Distance in the 2D space = {0:f2}",
                DistanceCalculator.CalcDistanceBetweenPoints2D(1, -2, 3, 4));
            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                DistanceCalculator.CalcDistanceBetweenPoints3D(5, 2, -1, 3, -6, 4));

            Figure.Width = 3;
            Figure.Height = 4;
            Figure.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", Figure.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", Figure.CalcMainDiagonal());
            Console.WriteLine("Diagonal XY = {0:f2}", Figure.CalcFrontDiagonal());
            Console.WriteLine("Diagonal XZ = {0:f2}", Figure.CalcBaseDiagonal());
            Console.WriteLine("Diagonal YZ = {0:f2}", Figure.CalcSideDiagonal());
        }
    }
}
